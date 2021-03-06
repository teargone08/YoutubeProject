﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExtractor;

namespace YouTubeDownloader001
{
    public class YouTubeModel
    {
        public IEnumerable<VideoInfo> VideoInfo { get; set; }
        public string FolderPath { get; set; }//store the folder we designated in the folder browsing
        public string Link { get; set; }// this is the YouTube link we type in
        public string FilePath { get; set; }// store the folder location we setup earlier + the name of the file and its extension
        public VideoInfo Video { get; set; }// object is from YouTube extractor and contains info about the file to be downloaded

    }

    public class YouTubeVideoModel : YouTubeModel
    {
        public VideoDownloader VideoDownloaderType { get; set; }
        // this is the object that contain the execute method,so we can download files
        //DownloadFinished event we can handle when a download is finished
        //we will use this to enable access to the interface after it's disabled while a file downlaods
        //DownloadProgressChange event which updates the progress bar as a video downloads
    }


    public class YouTubeAudioModel : YouTubeModel
    {
        public AudioDownloader AudioDownloaderType { get; set; }
        // this is the object that contain the execute  download audio method,so we can download files
        //DownloadFinished event we will use this to enable access to interface after it's disabled while a file download
        //DownloadProgressChange event, we will use to update the progress bar as a file downloads
    }
}
