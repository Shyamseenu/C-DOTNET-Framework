/*  write a program that finds number of element in an array with out using built in features */

using System;

public class arrayProgram
{
    static void Main()
    {
        string[] arr1 = new string[5];
        arr1[0] = "Apple";
        arr1[1] = "Orange";
        arr1[2] = "Banana";
        arr1[3] = "Mango";
        arr1[4] = "Grapes";

        int count = 0;

        foreach (string element in arr1)
        {
            count++; // Increment the count for each element
        }

        Console.WriteLine("Total elements in the array: " + count);
    }
}
