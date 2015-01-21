using System;

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

