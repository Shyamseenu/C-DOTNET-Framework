/* Find the area of the Square */

using System;
using System.ComponentModel;

public class areaOfSquare
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter the side of the Square : ");
        double side = Convert.ToInt32(Console.ReadLine());

        var area = side * side;

        Console.WriteLine("The area of the square is : " + area);
    }
}

