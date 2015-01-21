using System;

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
