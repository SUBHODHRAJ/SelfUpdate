using System;

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
        Console.WriteLine("The Details of Teacher and Student are : ");
        Console.WriteLine("Teacher Name : " + TeacherName);
        displayDetails();
    }
}

class Test
{
    static void Main(string[] args)
    {
        Teachers t = new Teachers();
        t.getDetails("Subhodhraj", "Computer Science");
        t.displayTeacherDetails();
        Console.WriteLine("Accessing Fields in Parent Class using Child Class");
        Console.WriteLine(t.Student_Name);
        Console.WriteLine(t.Department);
        Console.WriteLine();
        Console.WriteLine();
        t.getDetails("Dharun", "Computer Science");
        t.displayTeacherDetails();

    }
}