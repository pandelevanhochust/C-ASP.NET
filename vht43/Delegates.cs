namespace VHT;

public class Delegates
{
    delegate int Transformer(int x);
    delegate void ConsoleArray(int[] x);

    public static int Square(int x)=> x*x;
    public int Cube(int x) => x*x*x;

    private void Transform(int[] values, Transformer t) 
    {
        for(int i=0; i < values.Length; i++)
        {
            values[i] = t(values[i]);
        }
    }
    
    private void PrintArray(int[] values)
    {
        foreach(int i in values)
        {
            Console.Write(i + " ");
        }
    }
    
    public void Execute()
    {
        Transformer t = Square;

        Transformer s = (int x) => x+2;

        int ans = t(3); //9

        int sum = s(20); //22

        int sum2 = s.Invoke(20); //22

        Console.WriteLine(sum2);
    }

    public void MultiExecute()
    {
        int[] values = {1,2,3};
        Transformer t = Cube;
        ConsoleArray a = PrintArray;
        
        Console.WriteLine(t.Target);
        Console.WriteLine(a.Target);

        Transform(values, t);
        a(values);
    }
}