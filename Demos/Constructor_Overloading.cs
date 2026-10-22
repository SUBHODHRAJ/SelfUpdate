
using System;

class OverLoad
{
    string name;
    int age;

    // Default constructor
    public OverLoad()
    {
        name = "Abc";
        age = 20;
    }

    // Constructor with one parameter
    public OverLoad(string n)
    {
        name = n;
        age = 20;
    }

    // Constructor with two parameters
    public OverLoad(string n, int a)
    {
        name = n;
        age = a;
    }

    public void display()
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }

    static void Main()
    {
        OverLoad obj1 = new OverLoad();
        obj1.display();

        OverLoad obj2 = new OverLoad("John");
        obj2.display();

        OverLoad obj3 = new OverLoad("Alice", 25);
        obj3.display();
    }
}
