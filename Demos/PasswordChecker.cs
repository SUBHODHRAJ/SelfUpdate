
using System;

class Program
{
    static void Main()
    {
        string password, rating;
        do
        {
            bool upper = false;
            bool lower = false;
            bool digit = false;
            bool special = false;
            bool space = false;
            Console.Write("Enter password: ");
            password = Console.ReadLine() ?? "";
            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];
                if (char.IsUpper(c)) upper = true;
                else if (char.IsLower(c)) lower = true;
                else if (char.IsDigit(c)) digit = true;
                else if (c == ' ') space = true;
                else special = true;
            }
            Console.WriteLine("8+ characters: " + (password.Length >= 8 ? "Passed" : "Failed"));
            Console.WriteLine("Uppercase: " + (upper ? "Passed" : "Failed"));
            Console.WriteLine("Lowercase: " + (lower ? "Passed" : "Failed"));
            Console.WriteLine("Digit: " + (digit ? "Passed" : "Failed"));
            Console.WriteLine("Special character: " + (special ? "Passed" : "Failed"));
            Console.WriteLine("No spaces: " + (!space ? "Passed" : "Failed"));

            if (password.Length >= 8 && upper && lower && digit && special && !space)
                rating = "Strong";
            else if (password.Length >= 6 && upper && lower && digit)
                rating = "Medium";
            else
                rating = "Weak";
            Console.WriteLine("Password rating: " + rating);
        } while (rating != "Strong");
        Console.WriteLine("Strong password accepted!");
    }
}
