using CSharpTubeDownloader.Services;

namespace CSharpTubeDownloader.Controllers
{
    internal class DownloadMediaController
    {
        public void StartDownload(string youtubeLink, string destinationFolder, string fileFormat, ProgressBar progressBar)
        {
            YoutubeService youtubeService = new YoutubeService();
            youtubeService.DownloadVideoAsync(youtubeLink, destinationFolder, fileFormat.ToLower(), progressBar);
        }
    }
}
