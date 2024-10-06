using System;

class Program
{
    static void Main()
    {
        // Read start and end of the range
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        // Loop through the range
        for (int number = start; number <= end; number++)
        {
            if (IsPrime(number)) // Check if the number is prime
            {
                Console.WriteLine(number); // Print the prime number
            }
        }
    }

    // Function to check if a number is prime
    static bool IsPrime(int number)
    {
        if (number <= 1) return false; // Prime numbers are greater than 1
        if (number == 2) return true;  // 2 is a prime number
        if (number % 2 == 0) return false; // Exclude even numbers > 2

        for (int i = 3; i * i <= number; i += 2) // Check for factors
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
