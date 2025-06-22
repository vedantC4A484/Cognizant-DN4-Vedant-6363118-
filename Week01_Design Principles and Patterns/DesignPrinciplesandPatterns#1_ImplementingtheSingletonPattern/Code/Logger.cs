using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternExample
{

    public class Logger
    {
        // Step 1: Private static instance
        private static Logger instance;

        // Step 2: Lock object for thread safety
        private static readonly object lockObj = new object();

        // Step 3: Private constructor
        private Logger()
        {
            Console.WriteLine("Logger initialized.");
        }

        // Step 4: Public static method to get instance
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
            return instance;
        }

        // Example method
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }

}
