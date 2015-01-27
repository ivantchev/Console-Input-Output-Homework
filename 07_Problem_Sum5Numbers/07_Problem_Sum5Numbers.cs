using System;
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
//Examples:

//numbers	sum
//1 2 3 4 5	15
//10 10 10 10 10	50
//1.5 3.14 8.2 -1 0	11.84
class Sum5Numbers
{
    static void Main()
    {
        Console.Write("Type 5 numbers separated by \"space\": ");
        string[] array = Console.ReadLine().Split();
        int a = int.Parse(array[0]);
        int b = int.Parse(array[1]);
        int c = int.Parse(array[2]);
        int d = int.Parse(array[3]);
        int e = int.Parse(array[4]);
        Console.WriteLine("\nThe sum is: " + (a + b + c + d + e));
    }
}

