using YoutubeExplode.Videos.Streams;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace CSharpTubeDownloader.Services
{
    internal class YoutubeService
    {
        private ProgressBar ProgressBar;
        private Button StartButton;

        public YoutubeService(ProgressBar progressBar = null, Button startButton = null)
        {
            ProgressBar = progressBar;
            StartButton = startButton;
        }

        public async void DownloadVideoAsync(string youtubeLink, string destinationFolderPath, string fileFormat)
        {
            StartDownloadEvent();
            YoutubeClient youtube = new YoutubeClient();
            Video video = await youtube.Videos.GetAsync(youtubeLink);

            if (video != null) {
                StreamManifest streamInfoSet = await youtube.Videos.Streams.GetManifestAsync(video.Id);
                IStreamInfo? streamInfo = null;

                switch(fileFormat)
                {
                    case "mp3":
                        streamInfo = streamInfoSet.GetAudioOnlyStreams().GetWithHighestBitrate();
                        break;

                    case "mp4":
                    case "avi":
                        streamInfo = streamInfoSet.GetMuxedStreams().GetWithHighestVideoQuality();
                        break;

                    default:
                        MessageBox.Show("Format not supported.", "Alert Message");
                        return;
                }

                if (streamInfo != null)
                {
                    string videoTitle = new string(video.Title.Where(c => !Path.GetInvalidFileNameChars().Contains(c)).ToArray());
                    string outputPath = Path.Combine(destinationFolderPath, $"{videoTitle}.{fileFormat}");

                    var progress = new Progress<double>(p => ProgressBar.Value = (int)(p * 100));
                    await youtube.Videos.Streams.DownloadAsync(streamInfo, outputPath, progress);

                    MessageBox.Show($"Download completed and saved to:: {outputPath}", "Alert Message");
                    FinishDownloadEvent();
                    return;
                }

                MessageBox.Show("Unable to find an available stream for the desired format.", "Alert Message");
                return;
            }

            MessageBox.Show("Unable to find the video.", "Alert Message");
        }

        private void StartDownloadEvent()
        {
            StartButton.Enabled = false;
            StartButton.Text = "Downloading...";
        }

        private void FinishDownloadEvent()
        {
            StartButton.Enabled = true;
            StartButton.Text = "Start";
            ProgressBar.Value = 0;
        }
    }
}
