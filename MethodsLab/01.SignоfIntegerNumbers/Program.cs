
int number = int.Parse(Console.ReadLine()); //input data from console

PrintIntNumber(number); // Calling the method to print the type of number

static void PrintIntNumber(int number) // Method to check if the number is negative, zero, or positive
{
    if (number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
    else if (number == 0) 
    {
        Console.WriteLine($"The number {number} is zero.");
    }
    else
    {
        // number > 0  
        Console.WriteLine($"The number {number} is positive.");
    }
}