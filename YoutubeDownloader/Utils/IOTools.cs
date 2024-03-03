using System.Reflection;

namespace YoutubeDownloader.Utils
{
    internal class IOTools
    {
        /// <summary>
        /// Статический метод получает папку в которой находится наше приложение.
        /// </summary>
        /// <returns>Путь к папке где лежит .exe файл.</returns>
        internal static String GetExecutingPath()
        {
            String codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            return Path.GetDirectoryName(Uri.UnescapeDataString(uri.Path));
        }
    }
}
