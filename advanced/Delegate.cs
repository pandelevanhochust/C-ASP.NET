using System;

public class DelegateExample
{
    delegate int Transformer(int x);

    int Square(int x) => x * x; 

}