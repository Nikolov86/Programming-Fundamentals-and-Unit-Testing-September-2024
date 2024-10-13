int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)     //Reading Int Array
                .ToArray();

int sumEven = 0;
int sumOdd = 0;

foreach (int number in numbers) 
{ 
    if (number % 2 == 0)  // Even condition
    {
        sumEven += number;
    }
    else // Odd
    {
        sumOdd += number;
    }

}
Console.WriteLine(sumEven - sumOdd); // the difference between even and odd 
