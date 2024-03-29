﻿using System;
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
            
        }

        public void Info(string date, string message)
        {
            State state = State.Info;
            ILogFile file = new LogFile(date, state, message);
            foreach (IAppender appender in Appender)
            {
                appender.Append(file);
            }
        }
        public void Warning(string date, string message)
        {
            State state = State.Warning;
            ILogFile file = new LogFile(date, state, message);
            foreach (IAppender appender in Appender)
            {
                appender.Append(file);
            }
        }
        public void Critical(string date, string message)
        {
            State state = State.Critical;
            ILogFile file = new LogFile(date, state, message);
            foreach (IAppender appender in Appender)
            {
                appender.Append(file);
            }
        }
        public void Fatal(string date, string message)
        {
            State state = State.Fatal;
            ILogFile file = new LogFile(date, state, message);
            foreach (IAppender appender in Appender)
            {
                appender.Append(file);
            }
        }
    }
}