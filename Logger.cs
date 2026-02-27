namespace MyProject;

public class Logger { public string Message { get; set; } }

public struct Reading
{
    public double Temp;
    public Logger MyLogger;

    // Add this to satisfy CS8983
    public Reading() 
    {
        Temp = 0;
        MyLogger = null;
    }

    public static void DoSometimes()
    {
        
    }
}

