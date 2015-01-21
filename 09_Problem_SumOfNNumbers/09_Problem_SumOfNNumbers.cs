using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Please type a number: ");
        double a = double.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < a; i++)
        {
            Console.Write("Please enter value: ");
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum of the number is: {0}", sum);
    }
}

