using System;

namespace SumCalculator

{
    class Program

    { 
        static void Main(string[] args)
        {
            
                     int num1, num2, sum;
            
             
                     Console.Write("Enter the first number: ");
                     num1 =
                     Convert.ToInt32(Console.ReadLine());

           
                      Console.Write("Enter the second number: ");
                      num2 =
                      Convert.ToInt32(Console.ReadLine());

            
                    sum = num1 + num2;
                    Console.WriteLine("The sum of " + num1 + " and "+ num2 +" is " +sum);

        


        }
    }
}