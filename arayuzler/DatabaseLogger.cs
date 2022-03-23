using System;

namespace arayuzler
{
public class DatabaseLogger : ILogger
    {
        public void writeLog()
        {
            
            System.Console.WriteLine("Database'e log yazar.");
            
        }
    }

}