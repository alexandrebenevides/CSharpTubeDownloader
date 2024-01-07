using YoutubeExplode.Videos.Streams;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace CSharpTubeDownloader.Services
{
    internal class YoutubeService
    {
        public async void DownloadVideoAsync(string youtubeLink, string destinationFolderPath, string fileFormat)
        {
            YoutubeClient youtube = new YoutubeClient();
            Video video = await youtube.Videos.GetAsync(youtubeLink);

            if (video != null) {
                StreamManifest streamInfoSet = await youtube.Videos.Streams.GetManifestAsync(video.Id);
                IStreamInfo streamInfo = null;

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
                        MessageBox.Show("Formato não suportado.", "Aviso");
                        return;
                }

                if (streamInfo != null)
                {
                    Stream videoStream = await youtube.Videos.Streams.GetAsync(streamInfo);
                    string videoTitle = new string(video.Title.Where(c => !Path.GetInvalidFileNameChars().Contains(c)).ToArray());
                    string outputPath = Path.Combine(destinationFolderPath, $"{videoTitle}.{fileFormat}");

                    Console.WriteLine($"Baixando vídeo para: {outputPath}");

                    using (var fileStream = File.OpenWrite(outputPath))
                    {
                        await videoStream.CopyToAsync(fileStream);
                    }

                    MessageBox.Show("Download concluído!", "Aviso");
                    return;
                }

                MessageBox.Show("Não foi possível encontrar uma stream disponível para o formato desejado.", "Aviso");
                return;
            }

            MessageBox.Show("Não foi possível encontrar o vídeo.", "Aviso");
        }
    }
}
