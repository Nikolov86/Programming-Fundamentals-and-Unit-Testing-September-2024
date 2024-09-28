
int n = int.Parse(Console.ReadLine());

// Start the sequence with the first number 1
int currentNumber = 1;

// While the current number is less than or equal to n
while (currentNumber <= n)
{
    // Print the current number
    Console.WriteLine(currentNumber);

    // Calculate the next number in the sequence
    currentNumber = 2 * currentNumber + 1;
}