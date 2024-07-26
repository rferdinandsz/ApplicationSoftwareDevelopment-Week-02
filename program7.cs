using System;

namespace CircleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            const double pi = 3.14159;

            Console.Write("Enter the radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = pi * radius * radius;

            Console.WriteLine("The area of the circle with radius " + radius + " is " + area);
        }
    }
}
