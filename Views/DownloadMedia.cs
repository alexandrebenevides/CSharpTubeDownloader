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
            string selectedDownloadFormat = this.downloadFormatGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(radio => radio.Checked).Text;
            new DownloadMediaController().StartDownload(this.youtubeLink.Text, this.destinationFolder.Text, selectedDownloadFormat, this.progressBar);
        }

        public ProgressBar ProgressBar
        {
            get { return this.progressBar; }
            set { this.progressBar = value; }
        }


    }
}
