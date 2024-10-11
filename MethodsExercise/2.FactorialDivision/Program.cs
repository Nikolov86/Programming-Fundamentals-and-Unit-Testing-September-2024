using System;

class Program
{
    static void Main()
    {
        // Read the two integer numbers in range [1...10]
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        // Calculate the factorial of both numbers
        long factorialFirst = CalculateFactorial(firstNumber);
        long factorialSecond = CalculateFactorial(secondNumber);

        // Perform integer division of the first factorial by the second
        long result = factorialFirst / factorialSecond;

        // Print the result of the division
        Console.WriteLine(result);
    }

    // Method to calculate the factorial of a number
    static long CalculateFactorial(int number)
    {
        long factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
