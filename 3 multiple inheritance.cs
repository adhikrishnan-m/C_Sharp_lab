using System;

interface A
{
    void Display();
}

interface B
{
    void Show();
}

class C : A, B
{
    public void Display()
    {
        Console.WriteLine("Interface A");
    }

    public void Show()
    {
        Console.WriteLine("Interface B");
    }
}

class Program
{
    static void Main()
    {
        C obj = new C();
        obj.Display();
        obj.Show();
    }
}