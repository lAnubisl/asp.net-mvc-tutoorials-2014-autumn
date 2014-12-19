using System;

namespace UnitTests
{
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine(message);
        }
    }
}