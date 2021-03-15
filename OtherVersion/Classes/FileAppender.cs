using System.IO;
using OtherVersion.Enums;
using OtherVersion.Interfaces;

namespace OtherVersion.Classes
{
    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout) 
            : base(layout)
        {

        }

        public override void Append(string date, ReportLeve reportLevel, string message)
        {
            string content = string.Format(layout.Type, date, reportLevel, message);

            FileStream file = new FileStream(@"../../../log.txt", FileMode.Append);

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(content);
            }
        }
    }
}