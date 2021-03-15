using OtherVersion.Enums;
using OtherVersion.Interfaces;

namespace OtherVersion.Classes
{
    public abstract class Appender : IAppender
    {
        protected ILayout layout;

        public Appender(ILayout layout)
        {
            this.layout = layout;
        }

        public abstract void Append(string date, ReportLeve reportLevel, string message);
    }
}