using System;

namespace AccessDemo
{
public class Example
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
}