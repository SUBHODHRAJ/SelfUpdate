
using System;

class Gen<T>
{
    public T Value;

    public Gen(T value1)
    {ls
        Value = value1;
    }

    public int Add(int v1, int v2)
    {
        return v1 + v2;
    }

    public void Show()
    {
        Console.WriteLine("Type of T is " + typeof(T));
        Console.WriteLine("Value is " + Value);
    }
}

class Test
{
    static void Main()
    {
        Gen<int> g = new Gen<int>(10);

        Console.WriteLine(g.Add(10, 20));
        g.Show();
    }
}
