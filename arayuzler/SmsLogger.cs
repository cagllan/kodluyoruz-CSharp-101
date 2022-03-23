using System;

namespace arayuzler
{
    public class SmsLogger : ILogger
    {
        public void writeLog()
        {
            System.Console.WriteLine("Sms olarak yazar.");
        }
    }
}