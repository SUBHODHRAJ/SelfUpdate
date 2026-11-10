using System;
using System.IO;

class Student
{
    static void SaveStudent(string data)
    {
        StreamWriter sw = new StreamWriter("test.txt", true);
        sw.WriteLine(data);
        sw.WriteLine("-----------------------------------------------------------------------"); 
        sw.Close();
    }
    static void ReadStudent()
    {
        StreamReader sr = new StreamReader("test.txt");
        Console.WriteLine("\nStudent Details:");
        string? data;
        while ((data = sr.ReadLine()) != null)
        {
            Console.WriteLine(data);
        }
        sr.Close();
    }
    static void Main()
    {
        Action<string> save = SaveStudent;
        Action read = ReadStudent;

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
            string? dept = Console.ReadLine();

            string data = "ID: " + id + ", Name: " + name +", Age: " + age + ", Dept: " + dept;

            save(data);

            Console.WriteLine("Student details saved successfully!");
            Console.Write("Do you want to add another student? (y/n): ");
            choice = Console.ReadLine()!.ToLower();
        }
        read();
    }
}