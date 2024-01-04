namespace CSharpTubeDownloader
{
    public partial class MediaDownload : Form
    {
        public MediaDownload()
        {
            InitializeComponent();
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(this.folderBrowserDialog.SelectedPath)) {
                this.destinationFolder.Text = this.folderBrowserDialog.SelectedPath;
            }
        }
    }
}
