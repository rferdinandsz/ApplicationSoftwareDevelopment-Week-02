using System;

namespace RemainderCalculator
{
    class Program
    {
        static void Main(string[] args)
       { 

        int number1, number2, remainder;

        Console.Write("Enter the first number: ");
        number1 = 
        Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        number2 =
        Convert.ToInt32(Console.ReadLine());

        if (number2 != 0)
        {
            remainder = number1 % number2;
            Console.WriteLine("The Remainder is: " + remainder);
        }
        else
        {
              Console.WriteLine("Error: Division by zero is not allowed.");
        }


       }
    
    }
}