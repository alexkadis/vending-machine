using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone
{
    /// <summary>
    /// The Kickass Lumberjack Class
    /// </summary>
    public class Logger
    {
        public void Log(string message, decimal moneyBefore, decimal moneyAfter)
        {
            DateTime date = DateTime.Now;
            string logLine = $"{date.ToString("MM/dd/yyyy hh:mm:ss tt")} {message} {moneyBefore.ToString("C")} {moneyAfter.ToString("C")}";

            using (StreamWriter sw = new StreamWriter("Log.txt", true))
            {
                sw.WriteLine(logLine);
            }
        }
    }
}
