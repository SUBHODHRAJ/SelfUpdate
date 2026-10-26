using System;
abstract class Bank{
    public abstract void Account();

    public abstract void Display();
}
class AccHolder : Bank {
    public override void Account()
    {
        Console.WriteLine("Account information.");
    }
     public override void Display()
    {
        Console.WriteLine("Welcome to the bank.");
    }
}
class Program {
    static void Main()
    {
        AccHolder bank = new AccHolder();
        bank.Display();
        bank.Account();
    }
}