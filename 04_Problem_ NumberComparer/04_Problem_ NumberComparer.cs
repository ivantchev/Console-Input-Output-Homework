﻿using System;
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
//Examples:

//a	b	greater
//5	6	6
//10	5	10
//0	0	0
//-5	-2	-2
//1.5	1.6	1.6
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

