using System;
//write a program that reads 3 real numbers from the console and prints their sum.
//Examples:

//a	b	c	sum
//3	4	11	18
//-2	0	3	1
//5.5	4.5	20.1	30.1
class ProblemSumOf3Numbers
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter number c: ");
        double c = double.Parse(Console.ReadLine());

        double sum = (a + b + c);
        Console.WriteLine("\nThe sum of the numbers is: {0} ", sum);

    }
}
