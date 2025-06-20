// Logger.cs
using System;

public class Logger
{
    private static readonly Logger _instance = new Logger();

    private Logger()
    {
        Console.WriteLine("Logger initialized.");
    }

    // Public static method to return the singleton instance
    public static Logger Instance
    {
        get
        {
            return _instance;
        }
    }

    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}
