namespace MyProject;

public class Consoles
{
    public static void DoWork()
    {
        // Change the look
        System.Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("--- C# Basic Types & Console Demo ---");
        // Console.ResetColor();

        // 1. Data Types
        string username = "DevUser";
        int sessionID = 1024;
        double temperature = 25.5;
        bool isActive = true;

        // 2. Output with String Interpolation
        Console.WriteLine($"User: {username} (ID: {sessionID})");
        Console.WriteLine($"Current Temp: {temperature}°C");
        Console.WriteLine($"System Active: {isActive}");

        // 3. User Input
        Console.Write("\nEnter your nickname: ");
        string input = Console.ReadLine(); // Reads input as a string

        Console.Write("Enter your age: ");
        // Console.ReadLine() always returns a string, so we must Parse it to an int
        int ageInput = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nHello {input}, you are {ageInput} years old!");

        // 4. Pause the program
        Console.WriteLine("\nPress [Enter] to exit...");
        Console.ReadLine();
    }
}