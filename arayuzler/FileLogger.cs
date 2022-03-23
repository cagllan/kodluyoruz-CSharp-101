using System;

namespace arayuzler
{
public class FileLogger : ILogger
    {
        public void writeLog()
        {
            System.Console.WriteLine("Dosyaya log yazar.");
            
        }
    }

}