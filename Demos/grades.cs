class Program
{
    static void Main()
    {   
        Console.Write("Enter your marks: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 50) Console.WriteLine("Fail");
        else if (n >=50 && n < 60) Console.WriteLine('E');
        else if (n >=60 && n < 70) Console.WriteLine('D');
        else if (n >=70 && n < 80) Console.WriteLine('C');
        else if (n >=80 && n < 90) Console.WriteLine('B');
        else if (n >=90 && n < 100) Console.WriteLine('A');
        else Console.WriteLine('S');
    }
}