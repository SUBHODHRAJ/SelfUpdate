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
        Employee emp1 = new Manager();
        Employee emp2 = new Developer();

        emp1.Display();
        emp1.CalculateSalary();

        emp2.CalculateSalary();
    }
}