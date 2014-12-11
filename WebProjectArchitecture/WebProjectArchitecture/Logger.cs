using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjectArchitecture
{
    public class Logger : ILogger
    {
        public Logger()
        {
            
        }
        public void Error(string message)
        {
            Console.WriteLine(message);
        }
    }
}