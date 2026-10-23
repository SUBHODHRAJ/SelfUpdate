using System;

class Student
{
    string name;
    int age;
    public Student(string name,int age)
    {
        this.name = name;
        this.age = age;
    }
    static void Main()
    {
        Student s = new Student("Sundu", 25);
        Console.WriteLine(s.name + " is " + s.age + " years old.");
    }
}