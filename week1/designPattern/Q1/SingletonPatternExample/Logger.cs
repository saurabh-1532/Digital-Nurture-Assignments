using System;

public class Logger
{
    private static Logger activeLogger;
    private static readonly object threadLock = new object();
    private int logCounter;

    private Logger()
    {
        logCounter = 0;
        Console.WriteLine("Logger system started.");
    }

    public static Logger FetchLogger()
    {
        if (activeLogger == null)
        {
            lock (threadLock)
            {
                if (activeLogger == null)
                {
                    activeLogger = new Logger();
                }
            }
        }
        return activeLogger;
    }

    public void RecordLog(string logMessage)
    {
        logCounter++;
        Console.WriteLine($"[Record {logCounter}] {logMessage}");
    }
}