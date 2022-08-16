using System;

namespace Common
{
    public class ConsoleLog
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
