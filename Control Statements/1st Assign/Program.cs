/* Write a program which asks the user for his login and password. 
Both must be strings. After 3 wrong attempts, the user will be rejected. */

using System;

public class UserAuthentication
{
    public static void Main()
    {
        const string correctUsername = "Shyam18";
        const string correctPassword = "Shyam@1812";
        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter your LoginID: ");
            var enteredUsername = Console.ReadLine();

            Console.Write("Enter your Password: ");
            var enteredPassword = Console.ReadLine();

            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                Console.WriteLine("Welcome! You are logged in successfully.");
                break;
            }
            else
            {
                attempts++;
                Console.WriteLine("Incorrect credentials. Please try again.");
            }
        }

        if (attempts >= 3)
        {
            Console.WriteLine("Too many incorrect attempts. Access denied.");
        }
    }
}
