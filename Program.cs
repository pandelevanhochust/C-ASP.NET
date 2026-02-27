using System.Collections;

namespace MyProject;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Call the method from StructWithoutNew
        StructWithoutNew.DoSomething();

        // Call the method from Arrays
        Arrays.CompareArrays();

        StructWithoutNew.Coords point = new StructWithoutNew.Coords(5, 10);

        Console.WriteLine($"Point coordinates: ({point.x}, {point.y})");
    
        var r1 = new Reading { Temp = 25.5, MyLogger = new Logger { Message = "Temperature reading" } };
        var r2 = r1;
        Logger logger1 = new Logger { Message = "Hello" };

        Arrays.MultiDimensionalArrays();

        int[] numbers = new int[10];
        numbers[1] = 42;

        Box<int> intBox = new Box<int>(123);
        intBox.Display();
        intBox.Value = 456;
        intBox.Display();
    }
}