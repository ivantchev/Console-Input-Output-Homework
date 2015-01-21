using System;

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

