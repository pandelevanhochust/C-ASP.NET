using MyProject;
namespace MyProject;

public static class StructWithoutNew
{
    public struct Coords
    {
        public double x;
        public double y;
    }

    public static void DoSomething()
    {
        Coords p;
        p.x = 3;
        p.y = 4;
        Console.WriteLine($"({p.x}, {p.y})");  // output: (3, 4)
    }
}