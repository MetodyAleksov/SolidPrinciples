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

        public override void Append(string date, ReportLeve reportLevel, string message)
        {
            string content = string.Format(this.layout.Type, date, reportLevel, message);
            Console.WriteLine(content);
        }
    }
}