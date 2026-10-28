using System;

class Program : Example
{
    static void Main(string[] args)
    {
        Program p = new Program();
        p.PublicMethod();        // Works if PublicMethod is static
        p.InternalMethod();            // Works: same assembly
        p.InternalProtectedMethod();   // Works: derived class, same assembly
        p.ProtectedMethod();          // Works: derived class
        // p.PrivateMethod();          // Error: private to Example

    }
}