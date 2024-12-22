using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Read the sequence of numbers from the console
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        // Read the bomb number and its power
        int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int bombNumber = bombInfo[0];
        int bombPower = bombInfo[1];

        // Process the sequence to detonate bombs
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bombNumber)
            {
                // Remove elements to the left of the bomb
                int startIndex = Math.Max(0, i - bombPower);
                int endIndex = Math.Min(numbers.Count - 1, i + bombPower);

                for (int j = endIndex; j >= startIndex; j--)
                {
                    numbers.RemoveAt(j);
                }

                // Adjust the index after removing elements
                i = startIndex - 1;
            }
        }

        // Calculate the sum of the remaining elements
        int sum = numbers.Sum();

        // Print the sum
        Console.WriteLine(sum);
    }
}
