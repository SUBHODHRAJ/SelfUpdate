using System;

class Calculator
{
    public void Calc(int a, int b)
    {
        Console.WriteLine("Addition: " + (a + b));
    }
    public void Calc(int a, int b, int c)
    {
        Console.WriteLine("Addition: " + (a + b + c));
    }
    public float Calc(float a, float b)
    {
        Console.WriteLine("Addition: " + (a + b));
        return a + b;
    }
    public float Calc(float a, float b, float c)
    {
        Console.WriteLine("Addition: " + (a + b + c));
        return a + b + c;
    }
    public bool Calc(bool a, bool b)
    {
        Console.WriteLine("Logical AND: " + (a && b));
        return a && b;
    }
    static void Main()
    {
        Calculator add = new Calculator();

        add.Calc(10, 20);
        add.Calc(10, 20, 30);
        add.Calc(10.5f, 20.6f);
        add.Calc(10.5f, 20.5f, 30.5f);
        add.Calc(true, true);
    }

}