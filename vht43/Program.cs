using System.Security.Cryptography.X509Certificates;

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
        
        // MultiDelegate md = new MultiDelegate();
        // md.MultiCast();

        // publisher
        UserInput userevent = new UserInput();

        userevent.Input();
        
        Square square = new Square();

        square.Sub(userevent);
        // subscriber
         
    }

    delegate int Test(int x);
}