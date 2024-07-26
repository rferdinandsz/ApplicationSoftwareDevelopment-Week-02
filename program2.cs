using System;

namespace ProductCalculator
{
    class Program
    {
        static void Main(string[] args)
       { 

        int number1, number2, product;

        Console.Write("Enter the first number: ");
        number1 = 
        Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        number2 =
        Convert.ToInt32(Console.ReadLine());

        product = number1 * number2;

        Console.WriteLine("The Product is: " + product);

       }
    
    }
}