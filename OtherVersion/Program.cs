using System;
using OtherVersion.Classes;
using OtherVersion.Interfaces;

namespace OtherVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            ILayout simpleLayout = new SimpleLayout();
            IAppender consoleAppender =
                new FileAppender(simpleLayout);
            ILogger logger = new Logger(consoleAppender);

            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");

        }
    }
}
