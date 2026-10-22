
using System;

class Privates
{
    // Private Constructor
    private Privates()
    {
        Console.WriteLine("Private constructor called.");
    }

    static void test()
    {
        Console.WriteLine("This is a private constructor test.");
    }

    static void Main()
    {
        Privates p = new Privates();
        // This is allowed inside the same class.
        test();
    }
}
