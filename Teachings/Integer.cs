using System;

namespace Teachings
{
    class Integer
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your roll number : ");
            int rollnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student name is: " + name);
            Console.WriteLine("Student roll number is: " + rollnumber);
        }
    }
}