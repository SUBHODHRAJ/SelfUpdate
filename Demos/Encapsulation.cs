
using System;

class Encapsulation
{
    static void Main(string[] args)
    {
        User bank = new User();

        Console.WriteLine("Initial Balance: " + bank.balance);

        bank.Deposit(500);
        bank.Withdraw(200);
        bank.Withdraw(2000);

        Console.WriteLine("Final Balance: " + bank.balance);
    }
}

class User
{
    private int BankBalance = 1000;

    public int balance
    {
        get { return BankBalance; }
    }

    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            BankBalance += amount;
            Console.WriteLine("Deposited: " + amount);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount!");
        }
    }

    public void Withdraw(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount!");
        }
        else if (amount > BankBalance)
        {
            Console.WriteLine("Insufficient Balance!");
        }
        else
        {
            BankBalance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }

        Console.WriteLine("Current Balance: " + BankBalance);
    }
}
