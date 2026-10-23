using System;

class Single_Inheritance
{
    static void Main(string[] args)
    {
        Teacher t = new Teacher();
        t.display_teacher();
        Cons
    }

}

class Student
{
    public string name = "Subhodhraj";
    public string std_dept = "Computer Science";

    public void display()
    {
        Console.WriteLine("Student Name : " + name);
        Console.WriteLine("Student Department : " + std_dept);
    }
}

class Teacher : Student
{
    public string teacher_name = "Mr. Tharik";

    public void display_teacher()
    {
        Console.WriteLine("Teacher Name : " + teacher_name);
        display();
    }

}



//Inheritance --- one class reuse the property, field and method to the another class
//parent class ---- > child class
//Super Class ----> Sub Class
//Base Class ----> Derived Class
/*Types of Inheritance
    Single Inheritance  : Parent class to child class
    Multiple Inheritance : Child class to multiple parent class
    Multilevel Inheritance : Parent class to child class to grand child class
    Hierarchical Inheritance : Parent class to multiple child class
    Hybrid Inheritance : Combination of multiple and multilevel inheritance
*/