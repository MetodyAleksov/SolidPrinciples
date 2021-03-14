using System;
using System.Text.RegularExpressions;
using SolidPrinciples.Contracts;

namespace SolidPrinciples.Models
{
    public class LogFile : ILogFile
    {
        public LogFile(string time, Type type, string message)
        {
            Time = time;
            Type = type;
            Message = message;
        }
        public string Time { get; private set; }
        public Type Type { get; private set; }
        public string Message { get; private set; }

        public int Size
        {
            get
            {
                int sum = 0;

                Regex charseparator = new Regex(@"(?<item>[A-Za-z])");

                MatchCollection matches = charseparator.Matches($"{Time}{Type.ToString()}{Message}");

                foreach (Match match in matches)
                {
                    sum += (int) match.Groups["item"].Value[0];
                }

                return sum;
            }
        }
    }
}