namespace Logger
{
    using System;
    using Interfaces;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevel.Info;
        }

        public ReportLevel ReportLevel { get; set; }

        public ILayout Layout { get; }

        public abstract void Append(DateTime date, ReportLevel reportLevel, string message);

        protected string GetFormattedLogEntry(DateTime date, ReportLevel reportLevel, string message)
        {
            return this.Layout.FormatLog(date, reportLevel, message);
        }
    }
}
