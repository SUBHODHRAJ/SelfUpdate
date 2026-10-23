using System;

class Multilevel_Inheritance
{
    static void Main(string[] args)
    {
        Principal p = new Principal();
        p.display_principal();
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

class Principal : Teacher
{
    public string principal_name = "John";

    public void display_principal()
    {
        Console.WriteLine("Principal Name : " + principal_name);
        display_teacher();
    }

}
