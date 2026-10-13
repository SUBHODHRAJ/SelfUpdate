
using System;
class Program
{
    static void Main()
    {
        int choice;
        do
        {
            
            Console.WriteLine("Simple Calculator Menu");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition selected");
                    Console.Write("Enter 1st numbers: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter 2nd numbers: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Result: " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Subtraction selected");
                    Console.Write("Enter 1st numbers: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter 2nd numbers: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Result: " + (x - y));
                    break;
                case 3:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != 3);
    }
}