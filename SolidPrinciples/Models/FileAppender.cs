using System.IO;
using SolidPrinciples.Contracts;

namespace SolidPrinciples.Models
{
    public class FileAppender : IAppender
    {
        public FileAppender(ILayout layout)
        {
            Layout = layout;
        }
        public ILayout Layout { get; }
        public void Append(ILogFile file)
        {
            FileStream fcreate = File.Open(@"../../../log.txt", FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fcreate))
            {
                writer.WriteLine(Layout.GetMessage(file));
            }
        }
    }
}