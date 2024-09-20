using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidName(string name)
    {
        // Regular expression to allow only alphabets, spaces, hyphens, and apostrophes
        string pattern = @"^[a-zA-Z\s'-]+$";

        return Regex.IsMatch(name, pattern);
    }

    static void Main()
    {
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        if (IsValidName(firstName) && IsValidName(lastName))
        {
            Console.WriteLine("Valid names!");
        }
        else
        {
            Console.WriteLine("Invalid names. Please enter valid alphabetic names.");
        }
    }
}