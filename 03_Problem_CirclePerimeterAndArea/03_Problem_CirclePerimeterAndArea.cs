using System;
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
//Examples:

//r	perimeter	area
//2	12.57	12.57
//3.5	21.99	38.48
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;

        double circleArea = (2 * (pi * radius));
        Console.WriteLine("\nThe area of the circle is: {0:F2}", circleArea);

        double circlePerimeter = (pi * (radius * radius));
        Console.WriteLine("\nThe perimeter of the circle is: {0:F2}", circlePerimeter);

    }
}

