using CSharpTubeDownloader.Models;
using CSharpTubeDownloader.Services;

namespace CSharpTubeDownloader.Controllers
{
    internal class DownloadMediaController
    {
        public void StartDownload(DownloadMedia form)
        {

            ValidationResponse validateValueInYoutubeLink = ValidationService.checkNullOrEmptyValue("YouTube Link", form.youtubeLink.Text);
            ValidationResponse validateValueInDestinationFolder = ValidationService.checkNullOrEmptyValue("Destination Folder", form.destinationFolder.Text);
            ValidationResponse validateIfIsYoutubeLink = ValidationService.checkYoutubeLink("YouTube Link", form.youtubeLink.Text);

            string selectedDownloadFormat = form.downloadFormatGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(radio => radio.Checked).Text;
            ValidationResponse validateValueInFileFormat = ValidationService.checkNullOrEmptyValue("Download Format", selectedDownloadFormat);

            if (validateValueInYoutubeLink.IsValid && validateValueInDestinationFolder.IsValid && validateValueInFileFormat.IsValid && validateIfIsYoutubeLink.IsValid)
            {
                YoutubeService youtubeService = new YoutubeService(form.progressBar, form.startButton);
                youtubeService.DownloadVideoAsync(form.youtubeLink.Text, form.destinationFolder.Text, selectedDownloadFormat.ToLower());
            }
        }
    }
}
