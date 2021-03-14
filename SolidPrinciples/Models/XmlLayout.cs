using System.Text;
using SolidPrinciples.Contracts;

namespace SolidPrinciples.Models
{
    public class XmlLayout : ILayout
    {
        public string GetMessage(ILogFile file)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"<log>");
            sb.AppendLine($"    <date>{file.Time}</date>");
            sb.AppendLine($"    <level>{file.Type}</level>");
            sb.AppendLine($"    <message>{file.Message}</message>");
            sb.Append($"</log>");

            return sb.ToString();
        }
    }
}