namespace CSharpTubeDownloader
{
    partial class DownloadMedia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formTitle = new Label();
            progressBar = new ProgressBar();
            startButton = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            youtubeLink = new TextBox();
            youtubeLinkLabel = new Label();
            downloadFormatAVI = new RadioButton();
            downloadFormatLabel = new Label();
            downloadFormatMP3 = new RadioButton();
            downloadFormatMP4 = new RadioButton();
            destinationFolderLabel = new Label();
            destinationFolder = new TextBox();
            selectFolderButton = new Button();
            SuspendLayout();
            // 
            // formTitle
            // 
            formTitle.AutoSize = true;
            formTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            formTitle.Location = new Point(135, 9);
            formTitle.Name = "formTitle";
            formTitle.Size = new Size(407, 46);
            formTitle.TabIndex = 0;
            formTitle.Text = "CSharpTubeDownloader";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 549);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(614, 42);
            progressBar.TabIndex = 1;
            // 
            // startButton
            // 
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Location = new Point(256, 464);
            startButton.Name = "startButton";
            startButton.Size = new Size(133, 51);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButtonClick;
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.Description = "Select a destination folder";
            // 
            // youtubeLink
            // 
            youtubeLink.Font = new Font("Segoe UI", 12F);
            youtubeLink.Location = new Point(18, 146);
            youtubeLink.Name = "youtubeLink";
            youtubeLink.Size = new Size(608, 34);
            youtubeLink.TabIndex = 3;
            // 
            // youtubeLinkLabel
            // 
            youtubeLinkLabel.AutoSize = true;
            youtubeLinkLabel.Font = new Font("Segoe UI", 12F);
            youtubeLinkLabel.Location = new Point(12, 115);
            youtubeLinkLabel.Name = "youtubeLinkLabel";
            youtubeLinkLabel.Size = new Size(127, 28);
            youtubeLinkLabel.TabIndex = 4;
            youtubeLinkLabel.Text = "YouTube Link";
            // 
            // downloadFormatAVI
            // 
            downloadFormatAVI.AutoSize = true;
            downloadFormatAVI.Checked = true;
            downloadFormatAVI.Location = new Point(18, 245);
            downloadFormatAVI.Name = "downloadFormatAVI";
            downloadFormatAVI.Size = new Size(52, 24);
            downloadFormatAVI.TabIndex = 5;
            downloadFormatAVI.TabStop = true;
            downloadFormatAVI.Text = "AVI";
            downloadFormatAVI.UseVisualStyleBackColor = true;
            // 
            // downloadFormatLabel
            // 
            downloadFormatLabel.AutoSize = true;
            downloadFormatLabel.Font = new Font("Segoe UI", 12F);
            downloadFormatLabel.Location = new Point(12, 200);
            downloadFormatLabel.Name = "downloadFormatLabel";
            downloadFormatLabel.Size = new Size(170, 28);
            downloadFormatLabel.TabIndex = 6;
            downloadFormatLabel.Text = "Download Format";
            // 
            // downloadFormatMP3
            // 
            downloadFormatMP3.AutoSize = true;
            downloadFormatMP3.Location = new Point(18, 275);
            downloadFormatMP3.Name = "downloadFormatMP3";
            downloadFormatMP3.Size = new Size(59, 24);
            downloadFormatMP3.TabIndex = 7;
            downloadFormatMP3.Text = "MP3";
            downloadFormatMP3.UseVisualStyleBackColor = true;
            // 
            // downloadFormatMP4
            // 
            downloadFormatMP4.AutoSize = true;
            downloadFormatMP4.Location = new Point(18, 305);
            downloadFormatMP4.Name = "downloadFormatMP4";
            downloadFormatMP4.Size = new Size(59, 24);
            downloadFormatMP4.TabIndex = 8;
            downloadFormatMP4.Text = "MP4";
            downloadFormatMP4.UseVisualStyleBackColor = true;
            // 
            // destinationFolderLabel
            // 
            destinationFolderLabel.AutoSize = true;
            destinationFolderLabel.Font = new Font("Segoe UI", 12F);
            destinationFolderLabel.Location = new Point(12, 351);
            destinationFolderLabel.Name = "destinationFolderLabel";
            destinationFolderLabel.Size = new Size(173, 28);
            destinationFolderLabel.TabIndex = 9;
            destinationFolderLabel.Text = "Destination Folder";
            // 
            // destinationFolder
            // 
            destinationFolder.Enabled = false;
            destinationFolder.Font = new Font("Segoe UI", 12F);
            destinationFolder.Location = new Point(18, 382);
            destinationFolder.Name = "destinationFolder";
            destinationFolder.ReadOnly = true;
            destinationFolder.Size = new Size(478, 34);
            destinationFolder.TabIndex = 10;
            // 
            // selectFolderButton
            // 
            selectFolderButton.FlatStyle = FlatStyle.Flat;
            selectFolderButton.Location = new Point(502, 382);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Size = new Size(124, 34);
            selectFolderButton.TabIndex = 11;
            selectFolderButton.Text = "Select";
            selectFolderButton.UseVisualStyleBackColor = true;
            selectFolderButton.Click += SelectFolderButtonClick;
            // 
            // DownloadMedia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 615);
            Controls.Add(selectFolderButton);
            Controls.Add(destinationFolder);
            Controls.Add(destinationFolderLabel);
            Controls.Add(downloadFormatMP4);
            Controls.Add(downloadFormatMP3);
            Controls.Add(downloadFormatLabel);
            Controls.Add(downloadFormatAVI);
            Controls.Add(youtubeLinkLabel);
            Controls.Add(youtubeLink);
            Controls.Add(startButton);
            Controls.Add(progressBar);
            Controls.Add(formTitle);
            Name = "DownloadMedia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CSharpTubeDownloader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formTitle;
        private Button startButton;
        private FolderBrowserDialog folderBrowserDialog;
        private TextBox youtubeLink;
        private Label youtubeLinkLabel;
        private RadioButton downloadFormatAVI;
        private Label downloadFormatLabel;
        private RadioButton downloadFormatMP3;
        private RadioButton downloadFormatMP4;
        private Label destinationFolderLabel;
        private TextBox destinationFolder;
        private Button selectFolderButton;
        public ProgressBar progressBar;
    }
}
