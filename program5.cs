using System;

namespace Tempconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius, fahrenheit;

            Console.Write("Enter the temperature in celcius: ");
            celcius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = ( celcius * 9 / 5) + 32;

            Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit);

        }
    }
}