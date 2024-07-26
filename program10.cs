using System;

namespace TimeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalMinutes, hours, minutes;

            Console.Write("Enter the total minutes: ");
            totalMinutes = Convert.ToInt32(Console.ReadLine());

            hours = totalMinutes / 60;
            minutes = totalMinutes % 60;

            Console.WriteLine(totalMinutes + " minutes is equal to " + hours + " hours and " + minutes + " minutes.");
        }
    }
}
