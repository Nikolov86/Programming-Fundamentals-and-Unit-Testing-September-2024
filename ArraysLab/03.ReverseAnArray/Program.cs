int countNumbers = int.Parse(Console.ReadLine());

int[] numbers = new int[countNumbers];

// We loop over every single number starting from 0
for (int number = 0; number < countNumbers; number++)
{
    int value = int.Parse(Console.ReadLine());
    numbers[number] = value;  // Storing value in the correct index
}

// Reverse and print numbers
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}
