using System;

namespace AverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, number3, average;

            Console.Write("Enter the first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            average = (number1 + number2 + number3) / 3;

            Console.WriteLine("The average of " + number1 + ", " + number2 + ", and " + number3 + " is " + average);
        }
    }
}
