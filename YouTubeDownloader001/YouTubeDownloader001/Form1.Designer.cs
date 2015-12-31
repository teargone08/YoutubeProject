﻿namespace YouTubeDownloader001
{
    partial class frmYTDownloader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYTDownloader));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDecorateFolderBox = new System.Windows.Forms.Label();
            this.txtDownloaderFolder = new System.Windows.Forms.TextBox();
            this.btnDownloaderFolder = new System.Windows.Forms.Button();
            this.chkOpenAfterDownload = new System.Windows.Forms.CheckBox();
            this.lblDecorateURLBox = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.cboFileType = new System.Windows.Forms.ComboBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblDecorateCurrentFile = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblDecorateProgressBar = new System.Windows.Forms.Label();
            this.pgDownload = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.picPreviewBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(293, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDecorateFolderBox
            // 
            this.lblDecorateFolderBox.AutoSize = true;
            this.lblDecorateFolderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDecorateFolderBox.Location = new System.Drawing.Point(29, 187);
            this.lblDecorateFolderBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDecorateFolderBox.Name = "lblDecorateFolderBox";
            this.lblDecorateFolderBox.Size = new System.Drawing.Size(107, 17);
            this.lblDecorateFolderBox.TabIndex = 1;
            this.lblDecorateFolderBox.Text = "Download Path:";
            // 
            // txtDownloaderFolder
            // 
            this.txtDownloaderFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDownloaderFolder.Location = new System.Drawing.Point(184, 187);
            this.txtDownloaderFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDownloaderFolder.Name = "txtDownloaderFolder";
            this.txtDownloaderFolder.Size = new System.Drawing.Size(419, 23);
            this.txtDownloaderFolder.TabIndex = 2;
            // 
            // btnDownloaderFolder
            // 
            this.btnDownloaderFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDownloaderFolder.Location = new System.Drawing.Point(621, 187);
            this.btnDownloaderFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDownloaderFolder.Name = "btnDownloaderFolder";
            this.btnDownloaderFolder.Size = new System.Drawing.Size(88, 25);
            this.btnDownloaderFolder.TabIndex = 3;
            this.btnDownloaderFolder.Text = "Choose";
            this.btnDownloaderFolder.UseVisualStyleBackColor = true;
            this.btnDownloaderFolder.Click += new System.EventHandler(this.btnDownloaderFolder_Click);
            // 
            // chkOpenAfterDownload
            // 
            this.chkOpenAfterDownload.AutoSize = true;
            this.chkOpenAfterDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkOpenAfterDownload.Location = new System.Drawing.Point(741, 187);
            this.chkOpenAfterDownload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkOpenAfterDownload.Name = "chkOpenAfterDownload";
            this.chkOpenAfterDownload.Size = new System.Drawing.Size(162, 21);
            this.chkOpenAfterDownload.TabIndex = 4;
            this.chkOpenAfterDownload.Text = "Open After Download";
            this.chkOpenAfterDownload.UseVisualStyleBackColor = true;
            // 
            // lblDecorateURLBox
            // 
            this.lblDecorateURLBox.AutoSize = true;
            this.lblDecorateURLBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDecorateURLBox.Location = new System.Drawing.Point(29, 241);
            this.lblDecorateURLBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDecorateURLBox.Name = "lblDecorateURLBox";
            this.lblDecorateURLBox.Size = new System.Drawing.Size(102, 17);
            this.lblDecorateURLBox.TabIndex = 5;
            this.lblDecorateURLBox.Text = "YouTube URL:";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLink.Location = new System.Drawing.Point(184, 241);
            this.txtLink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(419, 23);
            this.txtLink.TabIndex = 6;
            // 
            // cboFileType
            // 
            this.cboFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboFileType.FormattingEnabled = true;
            this.cboFileType.Items.AddRange(new object[] {
            "Video",
            "MP3"});
            this.cboFileType.Location = new System.Drawing.Point(621, 241);
            this.cboFileType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFileType.Name = "cboFileType";
            this.cboFileType.Size = new System.Drawing.Size(87, 24);
            this.cboFileType.TabIndex = 7;
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDownload.Location = new System.Drawing.Point(741, 241);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(103, 32);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblDecorateCurrentFile
            // 
            this.lblDecorateCurrentFile.AutoSize = true;
            this.lblDecorateCurrentFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDecorateCurrentFile.Location = new System.Drawing.Point(29, 297);
            this.lblDecorateCurrentFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDecorateCurrentFile.Name = "lblDecorateCurrentFile";
            this.lblDecorateCurrentFile.Size = new System.Drawing.Size(115, 17);
            this.lblDecorateCurrentFile.TabIndex = 9;
            this.lblDecorateCurrentFile.Text = "File Downloading";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFileName.Location = new System.Drawing.Point(184, 297);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 17);
            this.lblFileName.TabIndex = 10;
            // 
            // lblDecorateProgressBar
            // 
            this.lblDecorateProgressBar.AutoSize = true;
            this.lblDecorateProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDecorateProgressBar.Location = new System.Drawing.Point(29, 338);
            this.lblDecorateProgressBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDecorateProgressBar.Name = "lblDecorateProgressBar";
            this.lblDecorateProgressBar.Size = new System.Drawing.Size(131, 17);
            this.lblDecorateProgressBar.TabIndex = 11;
            this.lblDecorateProgressBar.Text = "Download Progress";
            // 
            // pgDownload
            // 
            this.pgDownload.Location = new System.Drawing.Point(184, 338);
            this.pgDownload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgDownload.Name = "pgDownload";
            this.pgDownload.Size = new System.Drawing.Size(420, 31);
            this.pgDownload.TabIndex = 12;
            // 
            // picPreviewBox
            // 
            this.picPreviewBox.Location = new System.Drawing.Point(621, 32);
            this.picPreviewBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPreviewBox.Name = "picPreviewBox";
            this.picPreviewBox.Size = new System.Drawing.Size(184, 133);
            this.picPreviewBox.TabIndex = 13;
            this.picPreviewBox.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmYTDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 443);
            this.Controls.Add(this.picPreviewBox);
            this.Controls.Add(this.pgDownload);
            this.Controls.Add(this.lblDecorateProgressBar);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblDecorateCurrentFile);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.cboFileType);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblDecorateURLBox);
            this.Controls.Add(this.chkOpenAfterDownload);
            this.Controls.Add(this.btnDownloaderFolder);
            this.Controls.Add(this.txtDownloaderFolder);
            this.Controls.Add(this.lblDecorateFolderBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmYTDownloader";
            this.Text = "YouTube Downloader 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDecorateFolderBox;
        private System.Windows.Forms.TextBox txtDownloaderFolder;
        private System.Windows.Forms.Button btnDownloaderFolder;
        private System.Windows.Forms.CheckBox chkOpenAfterDownload;
        private System.Windows.Forms.Label lblDecorateURLBox;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.ComboBox cboFileType;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblDecorateCurrentFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblDecorateProgressBar;
        private System.Windows.Forms.ProgressBar pgDownload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox picPreviewBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;

    }
}

