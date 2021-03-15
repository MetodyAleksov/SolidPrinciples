using OtherVersion.Enums;

namespace OtherVersion.Interfaces
{
    public interface IAppender
    {
        void Append(string date, ReportLeve reportLevel, string message);
    }
}