using System;
class Employee
{
    public string name;
    public double salary;
}
class Manager : Employee
{
    public string department;
    public void Display()
    {
        Console.WriteLine("Manager Name: " + name);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Department: " + department);
    }
}

class HR : Employee
{
    public string field;

    public void Display()
    {
        Console.WriteLine("HR Name: " + name);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Field: " + field);
    }
}

class Program
{
    static void Main()
    {
        Manager m = new Manager();
        m.name = "Subhodh";
        m.salary = 50000;
        m.department = "IT";
        m.Display();

        Console.WriteLine();

        HR h = new HR();
        h.name = "Raj";
        h.salary = 40000;
        h.field = "Recruitment";
        h.Display();
    }
}