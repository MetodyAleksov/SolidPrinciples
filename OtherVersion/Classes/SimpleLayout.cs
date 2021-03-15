using OtherVersion.Interfaces;

namespace OtherVersion.Classes
{
    public class SimpleLayout : ILayout
    {
        public string Type => "{0} - {1} - {2}";
    }
}