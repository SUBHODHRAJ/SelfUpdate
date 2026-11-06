using System;
using System.IO;

class Student
{
    static void Main()
    {
        string path = "student.txt";
        string choice = "y";
        while (choice == "y")
        {
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string? name = Console.ReadLine();
            
            Console.Write("Enter Student Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Student Department: ");
            string? Dept = Console.ReadLine();
            
            StreamWriter sw = new StreamWriter(path, true);
            
            sw.WriteLine("ID: " + id + ", Name: " + name + ", Age: " + age + ", Dept: " + Dept);
            
            sw.Close();
            
            Console.WriteLine("Student details saved successfully!");
            
            Console.Write("Do you want to add another student? (y/n): ");
            
            choice = Console.ReadLine()!.ToLower();
        }

        StreamReader sr = new StreamReader(path);
        Console.WriteLine("\nStudent Details:");
        string? data;
        while ((data = sr.ReadLine()) != null)
        {
            Console.WriteLine(data);
        }
        sr.Close();
    }
}