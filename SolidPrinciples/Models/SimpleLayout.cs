using SolidPrinciples.Contracts;

namespace SolidPrinciples.Models
{
    public class SimpleLayout : ILayout
    {
        public string GetMessage(ILogFile file)
        {
            return $"{file.Time} - {file.Type} - {file.Message}";
        }
    }
}