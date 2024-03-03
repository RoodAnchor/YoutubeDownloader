using VideoLibrary;
using YoutubeDownloader.Properties;

namespace YoutubeDownloader.Services
{
    /// <summary>
    /// Класс выводящий данные о видео.
    /// </summary>
    internal class InfoPrinterService : IInfoPrinter
    {
        private String _url;

        internal InfoPrinterService(String url) =>
            _url = url;

        /// <summary>
        /// Метод получает дынные о виде через объект <see cref="Video"/> и выводит их в консоль.
        /// </summary>
        public void PrintInfo() 
        {
            YouTube youtube = YouTube.Default;

            Video video = youtube.GetVideo(_url);

            Console.WriteLine(Resources.VideoDetails);

            PrintLine(Resources.URL, _url);
            PrintLine(Resources.VideoTitle, video.Title);
            PrintLine(Resources.VideoAuthor, video.Info.Author);
            PrintLine(Resources.VideoDuration, video.Info.LengthSeconds.ToString());
        }

        private void PrintLine(String message, String param) =>
            Console.WriteLine(String.Format(message, "\t", param));
    }
}
