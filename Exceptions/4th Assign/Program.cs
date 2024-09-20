using System;

class Program
{
    static int GetIntegerInput(string prompt)
    {
        while (true)
        {
            try
            {
                Console.Write(prompt);
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter an integer.");
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter student's name: ");
        string studentName = Console.ReadLine();

        int subject1 = GetIntegerInput("Enter marks for subject 1: ");
        int subject2 = GetIntegerInput("Enter marks for subject 2: ");
        int subject3 = GetIntegerInput("Enter marks for subject 3: ");

        int totalMarks = subject1 + subject2 + subject3;
        double averageMarks = totalMarks / 3.0;

        Console.WriteLine($"Student: {studentName}");
        Console.WriteLine($"Average marks: {averageMarks:F2}");
    }
}