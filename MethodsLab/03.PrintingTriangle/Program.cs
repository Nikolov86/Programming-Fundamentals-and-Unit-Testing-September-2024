using System;

class Program
{
    static void Main()
    {
        // Step 1: Read the integer number N
        int n = int.Parse(Console.ReadLine());

        // Step 2: Call the method to print the triangle
        PrintTriangle(n);
    }

    // Step 3: Method to print a triangle of numbers
    static void PrintTriangle(int n)
    {
        // Printing the top part of the triangle
        for (int row = 1; row <= n; row++)
        {
            PrintRow(row);
        }

        // Printing the bottom part of the triangle (optional to reverse it)
        for (int row = n - 1; row >= 1; row--)
        {
            PrintRow(row);
        }
    }

    // Helper method to print a single row
    static void PrintRow(int rowNumber)
    {
        for (int i = 1; i <= rowNumber; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
