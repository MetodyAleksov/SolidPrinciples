using OtherVersion.Interfaces;

namespace OtherVersion.Classes
{
    public class XmlLayout : ILayout
    {
        public string Type => "<log>" +
                              "\n   <date>{0}</date>" +
                              "\n   <level>{1}</level>" +
                              "\n   <message>{2}</message>" +
                              "\n</log>";
    }
}