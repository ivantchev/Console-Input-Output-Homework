using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Type integer a between 0 and 500: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Type floating-point number b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Type floating-point number c: ");
        float c = float.Parse(Console.ReadLine());
        string convertA = Convert.ToString(a, 2).PadLeft(16, '0');

        Console.WriteLine("\nResult : ||{0,-10:X}|| {1}|| ||{2,10:F2} ||{3,-10:F3}   ", a, convertA, b, c);

    }
}

