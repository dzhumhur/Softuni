namespace Logger
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class Logger : ILogger
    {
        public Logger(params IAppender[] appender)
        {
            this.Appenders = new List<IAppender>(appender);
        }

        public IEnumerable<IAppender> Appenders { get; set; }

        public void Info(string message)
        {
            this.LogMessage(ReportLevel.Info, message);
        }

        public void Warning(string message)
        {
            this.LogMessage(ReportLevel.Warning, message);
        }

        public void Error(string message)
        {
            this.LogMessage(ReportLevel.Error, message);
        }

        public void Critical(string message)
        {
            this.LogMessage(ReportLevel.Critical, message);
        }

        public void Fatal(string message)
        {
            this.LogMessage(ReportLevel.Fatal, message);
        }

        private void LogMessage(ReportLevel reportLevel, string message)
        {
            var date = DateTime.Now;

            foreach (var appender in this.Appenders)
            {
                appender.Append(date, reportLevel, message);
            }
        }
    }
}
