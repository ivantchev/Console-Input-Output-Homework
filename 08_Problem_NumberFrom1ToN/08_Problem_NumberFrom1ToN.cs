using System;

class Problem_NumberFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Type integer n:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

