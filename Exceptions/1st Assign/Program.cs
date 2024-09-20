/* Write a Program to handle FormatException.  if a user enters values other than integer while entering 
the marks of each subject, catch FormatException. The name of the students and marks in 3 subjects are taken 
from the user while executing the program. */

using System;

class Programshyam
{
    static void Main()
    {
        try
        {
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter marks for Subject 1: ");
            int subject1Marks = int.Parse(Console.ReadLine());

            Console.Write("Enter marks for Subject 2: ");
            int subject2Marks = int.Parse(Console.ReadLine());

            Console.Write("Enter marks for Subject 3: ");
            int subject3Marks = int.Parse(Console.ReadLine());

            // Calculate total marks
            int totalMarks = subject1Marks + subject2Marks + subject3Marks;

            Console.WriteLine($"Student: {studentName}");
            Console.WriteLine($"Total Marks: {totalMarks}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter integer values for subject marks.");
        }
    }
}
