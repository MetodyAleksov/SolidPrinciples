using System;
using SolidPrinciples.Models;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleLayout = new SimpleLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);

            var file = new LogFile();
            var fileAppender = new FileAppender(simpleLayout);

            var logger = new Logger(consoleAppender, fileAppender);
            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

        }
    }
}
