using System;

class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message)
    {
    }
}

class Program
{
    static int GetNonNegativeIntegerInput(string prompt)
    {
        while (true)
        {
            try
            {
                int value = int.Parse(Console.ReadLine());
                if (value < 0)
                    throw new NegativeNumberException("Marks cannot be negative.");
                return value;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter student's name:");
        string studentName = Console.ReadLine();

        Console.WriteLine("Enter marks for subject 1:");
        int subject1 = GetNonNegativeIntegerInput("Subject 1: ");

        Console.WriteLine("Enter marks for subject 2:");
        int subject2 = GetNonNegativeIntegerInput("Subject 2: ");

        Console.WriteLine("Enter marks for subject 3:");
        int subject3 = GetNonNegativeIntegerInput("Subject 3: ");

        int totalMarks = subject1 + subject2 + subject3;
        double averageMarks = totalMarks / 3.0;

        Console.WriteLine($"Student: {studentName}");
        Console.WriteLine($"Total marks: {totalMarks}");
        Console.WriteLine($"Average marks: {averageMarks:F2}");
    }
}