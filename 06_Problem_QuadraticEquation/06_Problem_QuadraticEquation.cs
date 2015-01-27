using System;
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Examples:

//a	b	c	roots
//2	5	-3	x1=-3; x2=0.5
//-1	3	0	x1=3; x2=0
//-0.5	4	-8	x1=x2=4
//5	2	8	no real roots
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Type a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Type b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Type c: ");
        double c = double.Parse(Console.ReadLine());

        double D = Math.Pow(b, 2) - 4 * a * c;
        if (a != 0)
        {
            D = Math.Pow(b, 2) - 4 * a * c;
        }
        else
        {
            Console.WriteLine("Can not be solved");
        }
        if (D < 0)
        {
            Console.WriteLine("No Real roots");
        }
        if (D == 0)
        {
            double x = (-b) / (2 * a);
            Console.WriteLine("x1,x2: " + x);
        }
        if (D > 0)
        {
            double x1 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("x1: " + x1);
            double x2 = (-b + Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("x2: " + x2);

        }
    }
}

