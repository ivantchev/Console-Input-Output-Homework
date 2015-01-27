using System;
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
//Examples:

//numbers	sum
//3	90
//20	
//60	
//10	
//5	6.5
//2	
//-1	
//-0.5	
//4	
//2	
//1	1
//1	
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

