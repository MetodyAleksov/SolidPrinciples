using OtherVersion.Enums;
using OtherVersion.Interfaces;

namespace OtherVersion.Classes
{
    public class Logger : ILogger
    {
        private IAppender appender;

        public Logger(IAppender appender)
        {
            this.appender = appender;
        }

        public void Fatal(string date, string message)
        {
            throw new System.NotImplementedException();
        }

        public void Critical(string date, string message)
        {
            throw new System.NotImplementedException();
        }

        public void Warning(string date, string message)
        {
            throw new System.NotImplementedException();
        }

        public void Error(string date, string message)
        {
            appender.Append(date, ReportLeve.Error, message);
        }

        public void Info(string date, string message)
        {
            appender.Append(date, ReportLeve.Info, message);
        }
    }
}