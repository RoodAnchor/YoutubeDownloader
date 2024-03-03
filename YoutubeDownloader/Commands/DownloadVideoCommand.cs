using YoutubeDownloader.Services;

namespace YoutubeDownloader.Commands
{
    /// <summary>
    /// Класс с методами для скачивания видео.
    /// </summary>
    internal class DownloadVideoCommand : Command
    {
        private String _url;
        internal DownloadVideoCommand(String url) =>
            _url = url;

        private YoutubeService _youtubeService = YoutubeService.GetInstance();

        /// <summary>
        /// Метод запускает команду скачивания видео.
        /// </summary>
        internal override void Run() =>
            _youtubeService.Download(new DownloadService(_url));
    }
}
