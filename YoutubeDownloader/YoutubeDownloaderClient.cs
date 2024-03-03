using YoutubeDownloader.Commands;

namespace YoutubeDownloader
{
    /// <summary>
    /// Класс отправитель команды.
    /// </summary>
    internal class YoutubeDownloaderClient
    {
        private Command _command;

        /// <summary>
        /// Метод устанавливает команду.
        /// </summary>
        /// <param name="command">Команда которую необходимо выполнить.</param>
        internal void SetCommand(Command command) =>
            _command = command;

        /// <summary>
        /// Метод запускает команду.
        /// </summary>
        internal void Run() =>
            _command.Run();
    }
}
