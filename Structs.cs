using MyProject;
namespace MyProject;

public static class StructWithoutNew
{
    public readonly struct Coords
    {
        public double x{ get; }
        public double y{ get; }
        public Coords(double a, double b)
        {
            x = a;
            y = b;
        }
    }

    public static void DoSomething()
    {
        Coords p = new Coords(3, 4);
        Console.WriteLine($"({p.x}, {p.y})");  // output: (3, 4)
    }
}