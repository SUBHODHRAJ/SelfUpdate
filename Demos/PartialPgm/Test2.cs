
using System;

namespace PartialTest
{
    partial class PartialClass
    {
        partial void PartialMethod()
        {
            Console.WriteLine(5 + 2);
            Console.WriteLine();
        }

        public static void Testing()
        {
            Console.WriteLine("This is a method in the partial class.");
            Console.WriteLine();
        }
    }
}
    