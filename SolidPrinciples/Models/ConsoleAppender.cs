using System;
using SolidPrinciples.Contracts;

namespace SolidPrinciples.Models
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout)
        {
            Layout = layout;
        }
        public ILayout Layout { get; }
        public void Append(ILogFile file)
        {
            Console.WriteLine(Layout.GetMessage(file));
        }
    }
}