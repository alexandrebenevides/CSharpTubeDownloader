using CSharpTubeDownloader.Models;
using CSharpTubeDownloader.Services;

namespace CSharpTubeDownloader.Controllers
{
    internal class DownloadMediaController
    {
        public void StartDownload(string youtubeLink, string destinationFolder, string fileFormat, ProgressBar progressBar)
        {
            ValidationResponse validateValueInYoutubeLink = ValidationService.checkNullOrEmptyValue("YouTube Link", youtubeLink);
            ValidationResponse validateValueInDestinationFolder = ValidationService.checkNullOrEmptyValue("Destination Folder", destinationFolder);
            ValidationResponse validateValueInFileFormat = ValidationService.checkNullOrEmptyValue("Download Format", fileFormat);
            ValidationResponse validateIfIsYoutubeLink = ValidationService.checkYoutubeLink("YouTube Link", youtubeLink);

            if (validateValueInYoutubeLink.IsValid && validateValueInDestinationFolder.IsValid && validateValueInFileFormat.IsValid && validateIfIsYoutubeLink.IsValid)
            {
                YoutubeService youtubeService = new YoutubeService();
                youtubeService.DownloadVideoAsync(youtubeLink, destinationFolder, fileFormat.ToLower(), progressBar);
            }
        }
    }
}
