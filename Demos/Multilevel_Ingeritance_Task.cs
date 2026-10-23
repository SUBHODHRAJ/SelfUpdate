using System;
using System.Runtime.CompilerServices;

class Students
{
    public string? Student_Name;
    public string? Department;

    public void getDetails(string name, string department)
    {
        this.Student_Name = name;
        this.Department = department;
    }
    public void displayDetails()
    {
        Console.WriteLine("Student Name : " + Student_Name);
        Console.WriteLine("Student Department : " + Department);
    }
}
class Teachers : Students
{
    public string? TeacherName = "ABCD";
    public void displayTeacherDetails()
    {
        Console.WriteLine("Teacher Name : " + TeacherName);
        displayDetails();
    }
}

class Department : Teachers
{
    public string Dept_Name = "Computer Science and Engineering";

    public void displayDepartmentDetails()
    {
        Console.WriteLine("Details of Student and Teachers");
        displayTeacherDetails();
    }

}

class Admin
{
    static void Main()
    {
        Console.WriteLine("The report of the Department");
        Department d = new Department();
        d.getDetails("Subhodhraj","Computer Science and Engineering");
        d.displayDepartmentDetails();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Accessing Fields in Parent Class using Derived Child Class");
        Console.WriteLine("Student name is " + d.Student_Name);
        Console.WriteLine("Student department is " + d.Department);
        Console.WriteLine("Teacher name is " + d.TeacherName);
        Console.WriteLine("Department name is " + d.Dept_Name);
        d.displayDetails();

    }
}