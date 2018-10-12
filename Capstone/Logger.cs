namespace Capstone
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class Logger
    {
        public void Log(string message, decimal moneyBefore, decimal moneyAfter)
        {
            DateTime date = DateTime.Now;
            string dateString = date.ToString("MM/dd/yyyy hh:mm:ss tt");
            dateString = dateString.PadRight(30);

            message = message.PadRight(50);

            string moneyBeforeString = moneyBefore.ToString("C");
            moneyBeforeString = moneyBeforeString.PadLeft(10).PadRight(15);

            string moneyAfterString = moneyAfter.ToString("C").PadLeft(10);

            string logLine = $"{dateString} {message} {moneyBeforeString} {moneyAfterString}";

            try
            {
                using (StreamWriter sw = new StreamWriter("Log.txt", true))
                {
                    sw.WriteLine(logLine);
                }
            }
            catch
            {
                Console.WriteLine("Error when trying to log");
                return;
            }
        }
    }
}
