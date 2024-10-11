int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int numberThree = int.Parse(Console.ReadLine());

if (numberOne == 0 || numberTwo == 0 || numberThree == 0)
{
    // If any number is zero, the product is zero
    Console.WriteLine("zero");
}
else if ((numberOne > 0 && numberTwo > 0 && numberThree > 0) ||
         (numberOne < 0 && numberTwo < 0 && numberThree > 0) ||
         (numberOne < 0 && numberTwo > 0 && numberThree < 0) ||
         (numberOne > 0 && numberTwo < 0 && numberThree < 0))
{
    // If all numbers are positive or there is an even number of negatives, the product is positive
    Console.WriteLine("positive");
}
else
{
    // Otherwise, the product is negative
    Console.WriteLine("negative");
}
