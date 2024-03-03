namespace YoutubeDownloader.Services
{
    /// <summary>
    /// Синглтон<br/>
    /// Основной класс для скачивания и вывода инфо о видео.
    /// </summary>
    internal class YoutubeService
    {
        private static YoutubeService _instance;

        private YoutubeService() { }

        /// <summary>
        /// Статический метод возвращающий экземпляр класса
        /// </summary>
        /// <returns>Экземпляр класса</returns>
        internal static YoutubeService GetInstance()
        {
            if (_instance == null)
                _instance = new YoutubeService();

            return _instance;
        }

        /// <summary>
        /// Получает инфо о видео и выводит в консоль
        /// </summary>
        internal void PrintInfo(IInfoPrinter infoPrinter) =>
            infoPrinter.PrintInfo();

        /// <summary>
        /// Скачивает видео
        /// </summary>
        internal void Download(IVideoDownloader videoDownloader) =>
            videoDownloader.DownloadVideo();
    }
}
