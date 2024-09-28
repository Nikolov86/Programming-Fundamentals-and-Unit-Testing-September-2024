int number;

while (true)
{
    // Read and parse user input
    number = int.Parse(Console.ReadLine());

    // Check if the number is in the desired range
    if (number >= 1 && number <= 100)
    {
        // If valid, break the loop
        break;
    }
    else
    {
        // If invalid, prompt the user to try again
       
    }
}

Console.WriteLine(number);
