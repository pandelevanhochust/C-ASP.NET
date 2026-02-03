public struct Dimensions
{
    public readonly int Width { get; }
    public readonly int Height { get; }

    public const int Value = 100;

    public Dimensions(int width, int height)
    {

        Width = width;
        Height = height;
    }
}

public class Screen
{
    private static readonly Dimensions _resolution = new Dimensions(1920, 1080);

    public static ref readonly Dimensions GetResolution() //get the ref 
    {
        return ref _resolution;
    }

    public static void Display(ref readonly Dimensions d)
    {
        Console.WriteLine($"Width: {d.Width}, Height: {d.Height}");
    }
}

class Example
{
    public readonly int myConst = 2;
    public readonly int myConst2 = 10;

    public Example()
    {
        myConst2 = 3;
    }
}
class Program
{
    static void Main()
    {
        ref readonly Dimensions res = ref Screen.GetResolution();
        Console.WriteLine(res.Width + " x " + res.Height); // output: 1920 x 1080
        var d = new Dimensions(1300,600);
        Screen.Display(ref d);
        Console.WriteLine(Dimensions.Value); // output: 100
        // res.Width = 1280;  Error: cannot modify readonly reference
    }
}