using System;

class AccessModifiers
{
    public void PublicMethod()
    {
        Console.WriteLine("This is a public method.");
    }

    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("This is a protected method.");
    }

    internal void InternalMethod()
    {
        Console.WriteLine("This is an internal method.");
    }

    internal protected void InternalProtectedMethod()
    {
        Console.WriteLine("This is an internal protected method.");
    }
}

class Test : AccessModifiers
{
    static void Main()
    {
        Test test = new Test();

        test.PublicMethod();
       // test.PrivateMethod();
        test.InternalMethod();
        test.InternalProtectedMethod();
        test.ProtectedMethod();
    }
}