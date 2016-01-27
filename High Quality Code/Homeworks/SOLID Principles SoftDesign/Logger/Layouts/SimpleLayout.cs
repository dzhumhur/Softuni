namespace Logger
{
    using System;
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public string FormatLog(DateTime date, ReportLevel reportLevel, string message)
        {
            var formattedLog = $"{date} - {reportLevel} - {message}";

            return formattedLog;
        }
    }
}
