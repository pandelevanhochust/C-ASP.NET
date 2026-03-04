namespace VHT;

public class Program
{
    public static void Main(string[] args)
    {
        Delegates delegates= new Delegates();
        delegates.MultiExecute();

        Test sq = Delegates.Square;
        Test cube = delegates.Cube;

        Console.WriteLine(sq(10));
        Console.WriteLine(cube(10));
        Console.WriteLine(sq.Target);
        Console.WriteLine(cube.Target);
        
    }

    delegate int Test(int x);
}