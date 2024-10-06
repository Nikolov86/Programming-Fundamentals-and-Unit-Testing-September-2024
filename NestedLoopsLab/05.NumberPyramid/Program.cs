

int n = int.Parse(Console.ReadLine()); // Read the integer number from the console

int currentNumber = 1; // Starting number

for (int row = 1; row <= n; row++) // Loop through rows
{
    for (int col = 1; col <= row; col++) // Loop through columns in the current row
    {
        Console.Write(currentNumber + " "); // Print the current number with a space
        currentNumber++; // Increment the current number
        if (currentNumber > n) break; // Stop if the current number exceeds n
    }
    Console.WriteLine(); // Move to the next line after each row
    if (currentNumber > n) break; // Stop if the current number exceeds n

}