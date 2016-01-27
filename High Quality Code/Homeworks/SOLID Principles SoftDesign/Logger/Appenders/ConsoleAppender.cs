namespace Logger
{
    using System;

    using Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) 
               : base(layout)
        {
        }
        
        public override void Append(DateTime date, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                var formattedLogEntry = this.GetFormattedLogEntry(date, reportLevel, message);
                Console.WriteLine(formattedLogEntry);
            }
        }
    }
}
