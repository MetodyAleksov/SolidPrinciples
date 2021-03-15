using System.IO;
using System.Linq;
using OtherVersion.Interfaces;

namespace OtherVersion.Classes
{
    public class LogFile : ILogFile
    {
        private const string directory = "../../../log.txt";
        public int Size => File.ReadAllText(directory)
            .Where(x => char.IsLetter(x))
            .Sum(x => (int)x);
        public void Write(string content)
        {
            FileStream file = new FileStream(directory, FileMode.Append);
            
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(content);
            }
        }
    }
}