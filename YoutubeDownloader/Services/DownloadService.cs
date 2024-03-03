using VideoLibrary;
using YoutubeDownloader.Properties;

namespace YoutubeDownloader.Services
{
    /// <summary>
    /// Класс предоставляющий доступ к методу скачивания видео.
    /// </summary>
    internal class DownloadService : IVideoDownloader
    {
        private String _url;

        internal DownloadService(String url) =>
            _url = url;

        /// <summary>
        /// Метод получает детали видео через объект <see cref="Video"/> и сохраняет его на диск.
        /// </summary>
        public void DownloadVideo()
        {
            YouTube youtube = YouTube.Default;
            Video video = youtube.GetVideo(_url);

            Console.WriteLine(String.Format(Resources.DownloadingVideoFrom, _url));

            File.WriteAllBytes(video.FullName, video.GetBytes());

            Console.WriteLine(Resources.DowloadFinished);
        }
    }
}
