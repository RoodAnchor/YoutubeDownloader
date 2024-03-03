using YoutubeDownloader.Services;

namespace YoutubeDownloader.Commands
{
    /// <summary>
    /// Класс с методами для вывода деталей о видео.
    /// </summary>
    internal class PrintVideoInfoCommand : Command
    {
        private String _url;
        internal PrintVideoInfoCommand(String url) =>
            _url = url;

        private YoutubeService _youtubeService = YoutubeService.GetInstance();

        /// <summary>
        /// Запускает командку вывода инфо о видео.
        /// </summary>
        internal override void Run() => 
            _youtubeService.PrintInfo(new InfoPrinterService(_url));
    }
}
