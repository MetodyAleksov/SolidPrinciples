using System;
using System.Text;

namespace SolidPrinciples.Contracts
{
    public interface ILogFile
    {
        public string Time { get; }
        public Type Type { get; }
        public string Message { get; }
        public int Size { get; }
    }
}