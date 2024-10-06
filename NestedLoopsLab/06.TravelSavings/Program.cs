using System;

class Program
{
    static void Main(string[] args)
    {
        string destination = Console.ReadLine(); // Read the destination
        int moneyGoal = int.Parse(Console.ReadLine()); // Read the required money

        int sum = 0;

        while (destination != "End") // Continue until the destination is "End"
        {
            while (sum < moneyGoal) // Keep collecting until the goal is reached
            {
                int currentAmount = int.Parse(Console.ReadLine()); // Read the current amount of money
                sum += currentAmount; // Add the current amount to the total sum
                Console.WriteLine($"Collected: {sum:F2}"); // Display the collected money
            }

            // If the money goal is reached or exceeded
            Console.WriteLine($"Going to {destination}!");

            // Reset for the next destination
            sum = 0;
            destination = Console.ReadLine(); // Read the next destination
            if (destination != "End") // If not "End", read the new money goal
            {
                moneyGoal = int.Parse(Console.ReadLine());
            }
        }
    }
}
