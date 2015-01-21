using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Type first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Type second number: ");
        double b = double.Parse(Console.ReadLine());
        Boolean result = (a > b);
        Console.WriteLine("\nFirst number is greater than second ----> {0}", result);

    }
}

