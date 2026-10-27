using System;

class Number
{
    public int x;

    public Number(int a)
    {
        x = a;
    }

    public static Number operator -(Number n)
    {
        return new Number(-n.x);
    }
}

class Program
{
    static void Main()
    {
        Number n = new Number(10);
        Number result = -n;

        Console.WriteLine("Result = " + result.x);
    }
}