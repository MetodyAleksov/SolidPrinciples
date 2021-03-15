namespace OtherVersion.Interfaces
{
    public interface ILogger
    {
        public void Fatal(string date, string message);
        public void Critical(string date, string message);
        public void Warning(string date, string message);
        public void Error(string date, string message);
        public void Info(string date, string message);
    }
}