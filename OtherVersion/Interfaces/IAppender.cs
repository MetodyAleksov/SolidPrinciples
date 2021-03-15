using OtherVersion.Enums;

namespace OtherVersion.Interfaces
{
    public interface IAppender
    {
        void Append(string date, ReportLevel reportLevel, string message);
    }
}