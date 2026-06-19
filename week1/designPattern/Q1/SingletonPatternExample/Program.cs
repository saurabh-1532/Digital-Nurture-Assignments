
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Logger firstLogger = Logger.FetchLogger();
        Logger secondLogger = Logger.FetchLogger();

        
        firstLogger.RecordLog("System booted.");
        secondLogger.RecordLog("Connecting to database.");
        firstLogger.RecordLog("Connection successful.");

        Console.WriteLine("\n--- Validation ---");

       
        if (ReferenceEquals(firstLogger, secondLogger))
        {
            Console.WriteLine("Status: Pass.");
            Console.WriteLine("Both variables point to the exact same memory instance.");
        }
        else
        {
            Console.WriteLine("Status: Fail.");
            Console.WriteLine("Multiple objects detected.");
        }
    }
}