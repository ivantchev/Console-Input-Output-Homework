using System;

class NumbersDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Type a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Type b: ");
        int b = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + " ");
                count++;
            }

        }
        Console.WriteLine();
        Console.WriteLine("Number that exist between them: {0} ", count);

    }
}

