using YoutubeDownloader.Commands;
using YoutubeDownloader.Properties;

namespace YoutubeDownloader
{
    internal class Program
    {
        static void Main(String[] args)
        {
            String url = args.Length > 0 ? args[0] : null;

            try
            {
                YoutubeDownloaderClient client = new YoutubeDownloaderClient();

                client.SetCommand(new PrintVideoInfoCommand(url));
                client.Run();

                client.SetCommand(new DownloadVideoCommand(url));
                client.Run();
            }
            catch (Exception)
            {
                Console.WriteLine(Resources.VideoNotFoundMessage);
            }
            
        }
    }
}