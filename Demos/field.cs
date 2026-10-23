using System;
class Fields
{
    public string? name;
    public int age;
}
class Program
{
    static void Main()
    {
        Fields obj = new Fields();
        obj.name = "John";
        obj.age = 25;
        Console.WriteLine("Name: " + obj.name);
        Console.WriteLine("Age: " + obj.age);
    }
}