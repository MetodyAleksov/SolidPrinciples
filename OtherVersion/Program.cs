using System;
using System.Linq.Expressions;
using OtherVersion.Classes;
using OtherVersion.Enums;
using OtherVersion.Interfaces;

namespace OtherVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Appender[] appenders = new Appender[n];

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();

                if (arr[0] == "FileAppender")
                {
                    appenders[i] = new ConsoleAppender(GetLayout(arr[1]));
                }
                else if (arr[0] == "ConsoleAppender")
                {
                    appenders[i] = new FileAppender(GetLayout(arr[1]), new LogFile());
                }

                if (arr.Length == 3)
                {
                    appenders[i].ReportLevel = Enum.Parse<ReportLevel>(arr[2], true);
                }
            }

            ILogger logger = new Logger(appenders);

            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                ReportLevel rpl = Enum.Parse<ReportLevel>(input[0], true);
                string time = input[1];
                string msg = input[2];

                if (rpl == ReportLevel.Info)
                {
                    logger.Info(time, msg);
                }
                else if (rpl == ReportLevel.Warning)
                {
                    logger.Warning(time, msg);
                }
                else if (rpl == ReportLevel.Error)
                {
                    logger.Error(time, msg);
                }
                else if (rpl == ReportLevel.Critical)
                {
                    logger.Critical(time, msg);
                }
                else if (rpl == ReportLevel.Fatal)
                {
                    logger.Fatal(time, msg);
                }

                input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            }

            logger.GetLoggerInfo();
        }

        static ILayout GetLayout(string layoutType)
        {
            if (layoutType == "SimpleLayout")
            {
                return new SimpleLayout();
            }
            else if (layoutType == "XmlLayout")
            {
                return new XmlLayout();
            }

            return null;
        }
    }
}
