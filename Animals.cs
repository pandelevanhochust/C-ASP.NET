namespace MyProject;
public interface Covariance<out T>
{
    T Produce();
}

public interface Contravariance<in T>
{
    void Consume(T con);
}

public class AnimalHandler<T> : Covariance<T>, Contravariance<T>
{
    private T _value;

    public AnimalHandler(T initialValue)
    {
        _value = initialValue;
    }

    // Covariance: Produces T
    public T Produce() 
    {
        Console.WriteLine($"Producing {typeof(T).Name}");
        return _value;
    }

    // Contravariance: Consumes T
    public void Consume(T con)
    {
        Console.WriteLine($"Consuming {con?.GetType().Name ?? "null"}");
    }
}

public class Animals
{
    public void Speak(){}
}

public class Bear: Animals
{
    public void BearSpeak()
    {
        Console.WriteLine("Walfff");
    }
}

public class Holder<T>
{
    T value;

    public Holder(T v)
    {
        this.value = v;
    }
    
    public void Shout(T value)
    {

    }
}

public class Wash
{
    public static void Washer(Animals b)
    {
        
    }
}