using OtherVersion.Enums;
using OtherVersion.Interfaces;

namespace OtherVersion.Classes
{
    public abstract class Appender : IAppender
    {
        protected ReportLevel level = ReportLevel.Info;
        protected ILayout layout;

        public Appender(ILayout layout)
        {
            this.layout = layout;
        }

        public ReportLevel ReportLevel
        {
            get => level;
            set
            {
                level = value;
            }
        }

        public int MessagesAppended { get; protected set; }

        public abstract void Append(string date, ReportLevel reportLevel, string message);

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}," +
                   $" Layout type: {this.layout.GetType().Name}," +
                   $" Report level: {this.ReportLevel}," +
                   $" Messages appended: {MessagesAppended}";
        }
    }
}