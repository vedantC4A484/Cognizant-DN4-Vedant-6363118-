using SingletonPatternExample;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting application...\n");

        Logger logger1 = Logger.GetInstance();
        logger1.Log("First log message.");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("Second log message.");

        Console.WriteLine("\nChecking instance equality:");
        Console.WriteLine($"logger1 == logger2: {object.ReferenceEquals(logger1, logger2)}");

        Console.ReadLine();
    }
}
