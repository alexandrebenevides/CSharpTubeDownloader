using CSharpTubeDownloader.Controllers;
using CSharpTubeDownloader.Services;

namespace CSharpTubeDownloader
{
    public partial class DownloadMedia : Form
    {
        private YoutubeService youtubeService;

        public DownloadMedia()
        {
            InitializeComponent();
            this.youtubeService = new YoutubeService();
        }

        private void SelectFolderButtonClick(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(this.folderBrowserDialog.SelectedPath))
            {
                this.destinationFolder.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            new DownloadMediaController().StartDownload(this.youtubeLink.Text, this.destinationFolder.Text, "MP3");
        }

        public ProgressBar ProgressBar
        {
            get { return progressBar; }
            set { progressBar = value; }
        }
    }
}
