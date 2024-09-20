/* write a program to accept 10 integers to an array and perform the  below actions                                                             
1) Print  the elements in  descending  order                                                                                                                                         
2)  find the  Min value, Max value entered                                                                                                                                               
3)  print the the sum we  get after adding all the numbers in the  array */

using System;

class alterArray
{
    static void Main()
    {

        // Creating instance to the array
        int[] naturalNumbers = new int[10];

        //Accepting elements to the array
        Console.Write("First Element : ");
        naturalNumbers[0] = int.Parse(Console.ReadLine());

        Console.Write("Second Element : ");
        naturalNumbers[1] = int.Parse(Console.ReadLine());


        Console.Write("Third Element : ");
        naturalNumbers[2] = int.Parse(Console.ReadLine());


        Console.Write("Fourth Element : ");
        naturalNumbers[3] = int.Parse(Console.ReadLine());


        Console.Write("Fifth Element : ");
        naturalNumbers[4] = int.Parse(Console.ReadLine());


        Console.Write("Sixth Element : ");
        naturalNumbers[5] = int.Parse(Console.ReadLine());


        Console.Write("Seventh Element : ");
        naturalNumbers[6] = int.Parse(Console.ReadLine());


        Console.Write("Eighth Element : ");
        naturalNumbers[7] = int.Parse(Console.ReadLine());


        Console.Write("Ninth Element : ");
        naturalNumbers[8] = int.Parse(Console.ReadLine());


        Console.Write("Tenth Element : ");
        naturalNumbers[9] = int.Parse(Console.ReadLine());

        System.Console.WriteLine("The elements in the array are : ");
        foreach (int i in naturalNumbers)
        {

            Console.Write(i + " ");
        }

        // First Task

        Array.Sort(naturalNumbers);
        Array.Reverse(naturalNumbers);

        Console.WriteLine("\nElements in descending order:");
        foreach (int num in naturalNumbers)
        {
            Console.Write(num + " ");
        }

        // Second Task

        int minValue = naturalNumbers.Min();
        int maxValue = naturalNumbers.Max();

        Console.WriteLine("\nMin Value: " + minValue);
        Console.WriteLine("\nMax Value : " + maxValue);

        //Third Task

        int sum = 0;
        foreach (int num in naturalNumbers)
        {
            sum += num;
        }

        Console.WriteLine("\nSum of all elements:" + sum);

    }
}