using CSharpTubeDownloader.Exceptions;
using CSharpTubeDownloader.Services;

namespace CSharpTubeDownloader.Controllers
{
    internal class DownloadMediaController
    {
        public void StartDownload(DownloadMedia form)
        {
            try
            {
                ValidationService.checkNullOrEmptyValue("YouTube Link", form.youtubeLink.Text);
                ValidationService.checkNullOrEmptyValue("Destination Folder", form.destinationFolder.Text);
                ValidationService.checkYoutubeLink("YouTube Link", form.youtubeLink.Text);

                string selectedDownloadFormat = form.downloadFormatGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(radio => radio.Checked).Text;
                ValidationService.checkNullOrEmptyValue("Download Format", selectedDownloadFormat);

                YoutubeService youtubeService = new YoutubeService(form.progressBar, form.startButton);
                youtubeService.DownloadVideoAsync(form.youtubeLink.Text, form.destinationFolder.Text, selectedDownloadFormat.ToLower());
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Alert Message");
            }
        }
    }
}
