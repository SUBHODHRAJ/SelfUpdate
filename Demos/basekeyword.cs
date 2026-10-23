using System;
class Parent
{
    public void Display()
    {
        Console.WriteLine("Parent class");
    }
}
class Child : Parent
{
    public void Show()
    {
        base.Display();
        Console.WriteLine("Child class");
    }

    static void Main()
    {
        Child c = new Child();
        c.Show();
    }
}