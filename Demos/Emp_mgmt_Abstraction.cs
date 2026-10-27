using System;

abstract class Employee
{
    public abstract void CalculateSalary();
    public void Display()
    {
        Console.WriteLine("Employee Management System");
    }
}

class Manager : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Manager Salary: 50000");
    }
}

class Developer : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Developer Salary: 40000");
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Manager();
        Employee e2 = new Developer();

        e1.Display();
        e1.CalculateSalary();

        e2.CalculateSalary();
    }
}