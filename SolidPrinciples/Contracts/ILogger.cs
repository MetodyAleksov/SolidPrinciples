using System.Collections.Generic;

namespace SolidPrinciples.Contracts
{
    public interface ILogger
    {
        public List<IAppender> Appender { get; }

        public void Error(string date, string message);
        public void Info(string date, string message);
    }
}