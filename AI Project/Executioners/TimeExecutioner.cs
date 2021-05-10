using System;

namespace AI_Project.Executioners
{
    public class TimeExecutioner : IExecutioner
    {
        public bool ToLearn { get { return false; } }
        public string Info
        {
            get
            {
                return "<b>time format_string</b> - Tells the current time using the given format string. " +
                    "For more information about the format string, visit " +
                    "<a href=\"https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings\">this website. </a>" +
                    "If used without format string, it prints the output with the format string \"dd.MM.yyyy hh:mm: ss tt\".";
            }
        }

        public string Execute(string command)
        {
            var args = command.Split(new char[] { ' ' }, 2);
            if (args.Length == 1 && args[0] == "time")
            {
                return DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss tt");
            }
            if (args.Length > 2 || args[0] != "time")
            {
                return null;
            }
            return DateTime.Now.ToString(args[1]);
        }
    }
}