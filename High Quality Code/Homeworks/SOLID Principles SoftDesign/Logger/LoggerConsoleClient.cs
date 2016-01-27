namespace Logger
{
    using global::Logger.Interfaces;

    class LoggerConsoleClient
    {
        static void Main()
        {
            ILayout simpleLayout = new SimpleLayout();
            IAppender consoleAppender = new ConsoleAppender(simpleLayout);
            ILogger logger = new Logger(consoleAppender);
            string userName = "Mitko";

            logger.Error("Error when parsin JSON");
            logger.Info($"User {userName} was succesfully registered.");
        }
    }
}
