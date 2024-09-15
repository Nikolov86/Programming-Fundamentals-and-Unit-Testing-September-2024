using System;

namespace _9.DaysInMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  •	Read a single integer(the days to be converted)
            //•	Convert the days to minutes(1 day = 24 hours * 60 minutes)
            //•	Print the minutes in the following format: "Minutes = {calculated minutes}"

             int days = int.Parse(Console.ReadLine());

             int calculatedMinutes = days * 24 * 60;

             Console.WriteLine($"Minutes = {calculatedMinutes}");
            





        }
    }
}
