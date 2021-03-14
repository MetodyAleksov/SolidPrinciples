using System;
using System.Collections.Generic;
using SolidPrinciples.Contracts;
using SolidPrinciples.Enums;

namespace SolidPrinciples.Models
{
    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            Appender = new List<IAppender>();
            foreach (var appender in appenders)
            {
                Appender.Add(appender);
            }
        }
        public List<IAppender> Appender { get; }
        public void Error(string date, string message)
        {
            State state = State.Error;
            ILogFile file = new LogFile(date, state, message);
            foreach (IAppender appender in Appender)
            {
                appender.Append(file);
            }

            Console.WriteLine("Press any key to continue...");
        }

        public void Info(string date, string message)
        {
            State state = State.Info;
            ILogFile file = new LogFile(date, state, message);
            foreach (IAppender appender in Appender)
            {
                appender.Append(file);
            }
            Console.WriteLine("Press any key to continue...");
        }
    }
}