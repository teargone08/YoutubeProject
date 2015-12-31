using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
using YouTubeDownloader001;
using System.Diagnostics;
using System.Net;


namespace YouTubeDownloader001
{
    public partial class frmYTDownloader : Form
    {
        public frmYTDownloader()
        {
            InitializeComponent();
            cboFileType.SelectedIndex = 0;//set video as default choice
            //line below gets path to my documents
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //sets the path of the browser dialog box
            folderBrowserDialog1.SelectedPath = folder;
        }
             

        private void btnDownloaderFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result==DialogResult.OK)
            {
                txtDownloaderFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
 //           //our test youtube link
 //           string link = "https://www.youtube.com/watch?v=pv-6rweZR_s";

 //           /*
 //            * Get the available video formats.
 //            * We'll work with them in the video and audio download examples.
 //            */
 //           IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link);

 //           /*
 //* Select the first .mp4 video with 360p resolution
 //*/
 //           VideoInfo video = videoInfos
 //               .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

 //           /*
 //            * If the video has a decrypted signature, decipher it
 //            */
 //           if (video.RequiresDecryption)
 //           {
 //               DownloadUrlResolver.DecryptDownloadUrl(video);
 //           }

 //           /*
 //            * Create the video downloader.
 //            * The first argument is the video to download.
 //            * The second argument is the path to save the video file.
 //            */
 //           var videoDownloader = new VideoDownloader(video, Path.Combine(txtDownloaderFolder.Text, video.Title + video.VideoExtension));

 //           // Register the ProgressChanged event and print the current progress
 //           //videoDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage);

 //           /*
 //            * Execute the video downloader.
 //            * For GUI applications note, that this method runs synchronously.
 //            */
 //           videoDownloader.Execute();
            Tuple<bool, string> isLinkGood = ValidateLink();//get link validation results
            if (isLinkGood.Item1==true)
            {
                backgroundWorker1.RunWorkerAsync(isLinkGood.Item2);
                RestrictAccessibility();//call this to ensure controls don't work during a download
                Downloader(isLinkGood.Item2);
                //System.Threading.Thread.Sleep(2000);
                //EnableAccessibility();
                //Pass the validated link into the download method
                //so it can be assigned to a property in the YouTube video or audio model object
               //MessageBox.Show("Is it a good link? " + isLinkGood.Item1 + " Link is: " + isLinkGood.Item2);
            }
            
      }

        private void Downloader(string validatedLink)
        {
            if (cboFileType.SelectedIndex==0)
            {
                YouTubeVideoModel videoDownloader = new YouTubeVideoModel();
                videoDownloader.Link = validatedLink;
                videoDownloader.FolderPath = txtDownloaderFolder.Text;
                DownloadVideo(videoDownloader);
            }
            else
            {
                YouTubeAudioModel audioDownloader = new YouTubeAudioModel();
                audioDownloader.Link = validatedLink;
                audioDownloader.FolderPath = txtDownloaderFolder.Text;
                DownloadAudio(audioDownloader);
            }
        }

        private void DownloadAudio(YouTubeAudioModel audioDownloader)
        {
            try
            {
                //store VideoInfo object in model
                audioDownloader.VideoInfo = FileDownloader.GetVideoInfos(audioDownloader);
                //stores videoInfo object in model
                audioDownloader.Video = FileDownloader.GetVideoInfoAudioOnly(audioDownloader);
                UpdateLabel(audioDownloader.Video.Title + audioDownloader.Video.AudioExtension);
                //store FilePaht in model
                audioDownloader.FilePath = FileDownloader.GetPath(audioDownloader);
                audioDownloader.FilePath += audioDownloader.Video.AudioExtension;
                //store VideoDownloaderType object in model
                audioDownloader.AudioDownloaderType = FileDownloader.GetAudioDownloader(audioDownloader);
                //stop timer after download
                audioDownloader.AudioDownloaderType.DownloadFinished += (sender, args) => timer1.Stop();
                //Download video
                //Enable buttons once download is complete
                audioDownloader.AudioDownloaderType.DownloadFinished += (sender, args) => EnableAccessibility();
                //open folder with downloaded file selected
                audioDownloader.AudioDownloaderType.DownloadFinished += (sender, args) => OpenFolder(audioDownloader.FilePath);
                //Link progress bar up to download progress
                audioDownloader.AudioDownloaderType.DownloadProgressChanged += (sender, args) => pgDownload.Value = (int)args.ProgressPercentage;
                CheckForIllegalCrossThreadCalls = false;
                //download video
                FileDownloader.DownloadAudio(audioDownloader);
            }
            catch (Exception)
            {
                MessageBox.Show("Download canceled.");
                EnableAccessibility();
            }
        }

        private void DownloadVideo(YouTubeVideoModel videoDownloader)
        {
            try
            {
                //store VideoInfo object in model
                videoDownloader.VideoInfo = FileDownloader.GetVideoInfos(videoDownloader);
                //stores videoInfo object in model
                videoDownloader.Video = FileDownloader.GetVideoInfo(videoDownloader);
                UpdateLabel(videoDownloader.Video.Title + videoDownloader.Video.VideoExtension);
                //store FilePaht in model
                videoDownloader.FilePath = FileDownloader.GetPath(videoDownloader);
                videoDownloader.FilePath += videoDownloader.Video.VideoExtension;
                //store VideoDownloaderType object in model
                videoDownloader.VideoDownloaderType = FileDownloader.GetVideoDownloader(videoDownloader);
               //stop timer after download
                videoDownloader.VideoDownloaderType.DownloadFinished += (sender, args) => timer1.Stop();
                //Enable buttons once download is complete
                videoDownloader.VideoDownloaderType.DownloadFinished += (sender, args) => EnableAccessibility();
                //open folder with downloaded file selected
                videoDownloader.VideoDownloaderType.DownloadFinished += (sender, args) => OpenFolder(videoDownloader.FilePath);
                //Link progress bar up to download progress
                videoDownloader.VideoDownloaderType.DownloadProgressChanged += (sender, args) => pgDownload.Value = (int)args.ProgressPercentage;
                CheckForIllegalCrossThreadCalls = false;
                //download video
                FileDownloader.DownloadVideo(videoDownloader);
            }
            catch (Exception)
            {
                MessageBox.Show("Download canceled.");
                EnableAccessibility();
            }
        }

        private void UpdateLabel(string titleAndExtension)
        {
            lblFileName.Text = titleAndExtension;
        }

        private void OpenFolder(string filePath)
        {
            string argument = "/select,\"" + filePath + "\"";
            if (chkOpenAfterDownload.Checked==true)
            {
                Process.Start("explorer.exe", argument);
            }
        }

     

        private void EnableAccessibility()
        {
            lblFileName.Text = "";//clear file name label
            txtLink.Text = "";//clear the link from the link text box
            btnDownload.Enabled = true;//reenable the download button;
            btnDownloaderFolder.Enabled = true;//enable button for choosing folders
            txtLink.Enabled = true;//enable link box
            txtDownloaderFolder.Enabled = true;//enable download folder text box
            cboFileType.Enabled = true;//enable combo box
            pgDownload.Value = 0;//zero out progress bar
        }

        private void RestrictAccessibility()
        {
            btnDownload.Enabled = false;
            cboFileType.Enabled = false;
            btnDownloaderFolder.Enabled = false;
            txtDownloaderFolder.Enabled = false;
            txtLink.Enabled = false;
        }

        private Tuple<bool, string> ValidateLink()
        {
            string normalURL;
            if (!Directory.Exists(txtDownloaderFolder.Text))
            {
                MessageBox.Show("Please enter a valid folder.");
                return Tuple.Create(false, "");
            }
            else if (DownloadUrlResolver.TryNormalizeYoutubeUrl(txtLink.Text,out normalURL))
            {
                return Tuple.Create(true, normalURL);
            }
            else
            {
                MessageBox.Show("Please enter a valid YouTube link.");
                return Tuple.Create(false, "");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            string link = e.Argument as string;
            string youtubeCode = link.Substring(link.Length - 11, 11);
            string imageLink1 = "http://img.youtube.com/vi/" + youtubeCode + "/1.jpg";
            string imageLink2= "http://img.youtube.com/vi/" + youtubeCode + "/2.jpg";
            string imageLink3 = "http://img.youtube.com/vi/" + youtubeCode + "/3.jpg";
            using (var client=new WebClient())
            {
                client.DownloadFile(imageLink1, "1.jpg");
                client.DownloadFile(imageLink2, "2.jpg");
                client.DownloadFile(imageLink1, "3.jpg");
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer1.Start();
            timer1.Interval=500;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picPreviewBox.ImageLocation==null)
            {
                picPreviewBox.ImageLocation = "1.jpg";
            }
            if (picPreviewBox.ImageLocation=="1.jpg")
            {
                picPreviewBox.ImageLocation = "2.jpg";
            }
            else if (picPreviewBox.ImageLocation == "2.jpg")
            {
                picPreviewBox.ImageLocation = "3.jpg";
            }
            else if (picPreviewBox.ImageLocation == "3.jpg")
            {
                 picPreviewBox.ImageLocation = "1.jpg";
            }
        }
    }
}
