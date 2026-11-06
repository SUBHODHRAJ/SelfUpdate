using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter("employee.txt", true);

        string? ans = "Y";

        while (ans == "Y")
        {
            Console.Write("Enter Employee ID: ");
            string? id = Console.ReadLine();

            Console.Write("Enter Employee Name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            string? salary = Console.ReadLine();

            sw.WriteLine(id + " | " + name + " | " + salary);

            Console.WriteLine("Employee added successfully!");

            Console.Write("Add more employees? (Y/N): ");
            ans = Console.ReadLine().ToUpper();
        }

        sw.Close();

        Console.WriteLine("All employee details saved!");
    }
}