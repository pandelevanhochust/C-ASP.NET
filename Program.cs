using System.Collections;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

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
        
        Box<string> strBox = new Box<string>("gg");
        strBox.Display();

        int x = 5, y = 10;
        Swap<int>(ref x, ref y);

        string first = "World", second = "Hello";
        Swap<string>(ref first, ref second);

        Animals a1 = new Animals();
        Animals a2 = new Bear();
    
        var downcast = (Bear)a2;
        downcast.BearSpeak();

        Bear b1 = new Bear();

        a1 = b1;

        var hold = new Holder<int>(1);
        hold.Shout(1);

        // Holder<string> str = hold;

        var genAni = new Holder<Animals>(new Animals());
        var genBear = new Holder<Bear>(new Bear());
        
        //type safe

        var holdAnimals = new Holder<Animals>(new Animals());
        var holdBear = new Holder<Bear>(new Bear());

        // holdAnimals = holdBear;
        
        Covariance<Animals> coAni = null!;
        Covariance<Bear> coBear = null!;

        Contravariance<Animals> nAni= new AnimalHandler<Animals>(new Animals());
        Contravariance<Bear> nBear = new AnimalHandler<Bear>(new Bear());
       
        Covariance<Bear> cBear = new AnimalHandler<Bear>(new Bear());
        Covariance<Animals> cAni = new AnimalHandler<Animals>(new Animals());

        

        Animals ani1 = coAni.Produce();
                
    }

    private static void Swap<T> (ref T a, ref T b)
    {   
        T temp = a;
        a = b;
        b = temp;
    }    
 
}
