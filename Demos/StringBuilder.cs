using System;
using System.Text;
using System.Diagnostics;

class StringBuild
{
    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        StringBuilder sb = new StringBuilder("Hello");
        sb.Append(" World");
        for(int i=0; i<10000; i++)
        {
            sb.Append("!");
        }
        Console.WriteLine($"Capacity: {sb.Length}");
        sw.Stop();
        Console.WriteLine($"Time taken: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        string s = "Hello";
        s+=" World";
        for(int i=0; i<10000; i++)
        {
            s += "!";
        }
        Console.WriteLine($"Capacity: {s.Length}");
        s.AsMemory();
        sw.Stop();
        Console.WriteLine($"Time taken: {sw.ElapsedMilliseconds} ms");
    }
}