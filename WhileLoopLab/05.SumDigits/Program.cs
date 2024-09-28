int positiveNumber = int.Parse(Console.ReadLine());
int sum = 0;

// Loop until all digits are processed
while (positiveNumber > 0)
{
    // Get the last digit of the number
    int currentDigit = positiveNumber % 10;

    // Add the last digit to the sum
    sum += currentDigit;

    // Remove the last digit from the number (integer division by 10)
    positiveNumber /= 10;
}

// Print the result
Console.WriteLine(sum);
