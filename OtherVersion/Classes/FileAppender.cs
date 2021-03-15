using System.IO;
using OtherVersion.Enums;
using OtherVersion.Interfaces;

namespace OtherVersion.Classes
{
    public class FileAppender : Appender
    {
        private ILogFile file;
        public FileAppender(ILayout layout, ILogFile file) 
            : base(layout)
        {
            this.file = file;
        }

        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            if (ReportLevel <= reportLevel)
            {
                this.MessagesAppended++;
                string content = string.Format(layout.Type, date, reportLevel, message);

                this.file.Write(content);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, File size: {this.file.Size}";
        }
    }
}