using System;
using OtherVersion.Enums;
using OtherVersion.Interfaces;

namespace OtherVersion.Classes
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {

        }

        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            if (ReportLevel <= reportLevel)
            {
                this.MessagesAppended++;
                string content = string.Format(this.layout.Type, date, reportLevel, message);
                Console.WriteLine(content);
            }
        }
    }
}