
using System;

namespace PartialTest
{
    partial class PartialClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the main method of the partial class.");

            Testing();
            PartialClass o = new PartialClass();
            o.PartialMethod();

            Inheri obj = new Inheri();

            obj.inherited();
            obj.inherited(10);
        }

        partial void PartialMethod();


    }

    class Inheri : PartialClass
    {
        public void inherited()
        {
            Console.WriteLine("This is a method in the derived class.");
        }

        public void inherited(int n)
        {
            Console.WriteLine("The number passed is: " + n);
            Console.WriteLine("This is an overridden method in the derived class.");
        }
    }
}
