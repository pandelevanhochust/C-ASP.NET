using System;

namespace MyProject;

public class Program
{
    public static void Main()
    {
        var r1 = new Reading { Temp = 25.0, MyLogger = new Logger { Message = "All OK" } };
        var r2 = r1; // Copying the struct

        r2.Temp = 30.0;                 // Changes r2, but NOT r1 (Value type copy)
        r2.MyLogger.Message = "ERROR";  // Changes r2 AND r1! (Shared reference)

        Console.WriteLine($"r1.Temp={r1.Temp}, r1.Logger={r1.MyLogger.Message}");
        Console.WriteLine($"r2.Temp={r2.Temp}, r2.Logger={r2.MyLogger.Message}");
    }
}