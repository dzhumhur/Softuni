namespace Logger.Appenders
{
    using System;
    using System.IO;

    using Interfaces;

    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout)
            : base(layout)
        {
        }

        public string FilePath { get; set; }
        
        public override void Append(DateTime date, ReportLevel reportLevel, string message)
        {
            if (reportLevel <= this.ReportLevel)
            {
                return;
            }

            var formattedLogEntry = this.GetFormattedLogEntry(date, reportLevel, message);
            File.AppendAllText(this.FilePath, formattedLogEntry);
        }
    }
}
