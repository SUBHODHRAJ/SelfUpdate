using System;

class StringDemo
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine() ?? "Default String";
        Console.WriteLine($"You entered: {str}");
        Console.WriteLine($"Length of the string: {str.Length}");
        Console.WriteLine($"Uppercase: {str.ToUpper()}");
        Console.WriteLine($"Lowercase: {str.ToLower()}");
        Console.WriteLine($"Substring (first 5 characters): {str.Substring(0, Math.Min(5, str.Length))}");
        Console.WriteLine($"Does the string contain 'u'? {str.Contains('u')}");
        Console.WriteLine($"Contains 'ubh': {str.Contains("ubh")}");
        Console.WriteLine($"Starts with 'Su': {str.ToUpper().StartsWith("S")}");
        Console.WriteLine($"Ends with 'raj': {str.ToLower().EndsWith("raj")}");
        Console.WriteLine($"Index of 'a': {str.IndexOf('a')}");
        Console.WriteLine($"Replace 'S' with 'B': {str.Replace('S', 'B')}");

        string[] strs = {"Hello", "World", "from", "C#" };
        Console.WriteLine("Array of strings:");
        foreach (var s in strs)
        {
            Console.Write($"{s} ");
        }
        Console.WriteLine();        
        Console.WriteLine("UpperBound of the array: " + strs.GetUpperBound(0));
        Console.WriteLine("LowerBound of the array: " + strs.GetLowerBound(0));

    }
}