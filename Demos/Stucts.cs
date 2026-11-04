using System;

struct Student
{
    public string Name;
    public int Age;
    public double GPA;

    public Student(string name, int age, double gpa)
    {
        Name = name;
        Age = age;
        GPA = gpa;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, GPA: {GPA}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Alice", 20, 3.8);
        Student student2 = new Student("Bob", 22, 3.5);

        student1.DisplayInfo();
        student2.DisplayInfo();
    }
}