using System;

namespace TotalCostCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double itemPrice, taxRate, totalCost, taxAmount;

            Console.Write("Enter the item price: ");
            itemPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the tax rate (in percentage): ");
            taxRate = Convert.ToDouble(Console.ReadLine());

            taxAmount = itemPrice * (taxRate / 100);

            totalCost = itemPrice + taxAmount;

            Console.WriteLine("The total cost of the purchase is " + totalCost);
        }
    }
}
