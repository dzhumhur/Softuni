namespace Logger.Interfaces
{
    using System.Collections.Generic;

    public interface ILogger
    {
        IEnumerable<IAppender> Appenders { get; set; }

        void Info(string message);

        void Warning(string message);

        void Error(string message);

        void Critical(string message);

        void Fatal(string message);
    }
}
