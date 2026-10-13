using System;
class Bank
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Bank!");
        double balance = 1000.00;
        int pin = 1806;
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine() ?? "";
        if (name == "")
        {
            Console.WriteLine("Invalid account name. Please try again.");
            return;
        }
        Console.WriteLine($"Hello, {name}!");
        Console.Write("Please enter your 4-digit PIN: ");

        if (Convert.ToInt32(Console.ReadLine()) != pin)
        {
            Console.WriteLine("Incorrect PIN. Access denied.");
            return;
        }

        Console.WriteLine("Access granted.");

        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.Write("Choose an option: ");

        int ch = Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
            case 1:
                Console.WriteLine($"Your current balance is: ${balance:F2}");
                break;
            case 2:
                Console.Write("Enter the amount to deposit: ");
                if (Convert.ToDouble(Console.ReadLine()) is double deposit && deposit > 0)
                {
                    balance += deposit;
                    Console.WriteLine(
                        $"Deposited ${deposit:F2}. New balance: ${balance:F2}");
                }
                else
                {
                    Console.WriteLine("Enter a valid positive amount.");
                }
                break;
            case 3:
                Console.Write("Enter the amount to withdraw: ");
                if (Convert.ToDouble(Console.ReadLine()) is double withdraw && withdraw > 0)
                {
                    if (withdraw <= balance)
                    {
                        balance -= withdraw;
                        Console.WriteLine(
                            $"Withdrew ${withdraw:F2}. New balance: ${balance:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance.");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid positive amount.");
                }
                break;
            default:
                Console.WriteLine("Invalid option selected.");
                break;
        }
    }
}
