using System;
using System.Text;
using SolidPrinciples.Enums;

namespace SolidPrinciples.Contracts
{
    public interface ILogFile
    {
        public string Time { get; }
        public State Type { get; }
        public string Message { get; }
        public int Size { get; }
    }
}