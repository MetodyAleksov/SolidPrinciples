using System;
using OtherVersion.Enums;
using OtherVersion.Interfaces;

namespace OtherVersion.Classes
{
    public class Logger : ILogger
    {
        private readonly IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public void GetLoggerInfo()
        {
            Console.WriteLine("Logger info");
            foreach (Appender appender in appenders)
            {
                appender.ToString();
            }
        }

        public void Fatal(string date, string message)
        {
            foreach (IAppender appender in appenders)
            {
                appender.Append(date, ReportLevel.Fatal, message);
            }
        }

        public void Critical(string date, string message)
        {
            foreach (IAppender appender in appenders)
            {
                appender.Append(date, ReportLevel.Critical, message);
            }
        }

        public void Warning(string date, string message)
        {
            foreach (IAppender appender in appenders)
            {
                appender.Append(date, ReportLevel.Warning, message);
            }
        }

        public void Error(string date, string message)
        {
            foreach (IAppender appender in appenders)
            {
                appender.Append(date, ReportLevel.Error, message);
            }
        }

        public void Info(string date, string message)
        {
            foreach (IAppender appender in appenders)
            {
                appender.Append(date, ReportLevel.Info, message);
            }
        }
    }
}