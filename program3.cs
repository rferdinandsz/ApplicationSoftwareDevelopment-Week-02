using System;

namespace QuotientCalculator
{
    class Program
    {
        static void Main(string[] args)
       { 

        int number1, number2, quotient;

        Console.Write("Enter the first number: ");
        number1 = 
        Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        number2 =
        Convert.ToInt32(Console.ReadLine());
        if (number2 != 0)

        {

        quotient = number1 / number2;

        Console.WriteLine("The Quotient is: " + quotient);

        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }

       }
    
    }
}