using System;
class Student // class
{

    string? name;
    int? age;
    public Student()
    {
        Console.WriteLine("Default Constructor created...");
    }
    public Student(int a)
    {
        Console.WriteLine("Parameterized Constructor created...");
    }
    public Student(string n, int a)
    {
        name = n;
        age = a;
        Console.WriteLine("Name: " + name + ", Age: " + age);
        Console.WriteLine("Parameterized Constructor initialized with name and age");
    }
    public Student(Student obj)
    {
        this.name = obj.name;
        this.age = obj.age;
    }
    public static void Main()
    {
        Student consts = new Student();
        Student consts2 = new Student("John", 25);
        Student consts3 = new Student(consts2);
        Console.WriteLine("Copied Name: " + consts3.name + ", Copied Age: " + consts3.age);
    }
}