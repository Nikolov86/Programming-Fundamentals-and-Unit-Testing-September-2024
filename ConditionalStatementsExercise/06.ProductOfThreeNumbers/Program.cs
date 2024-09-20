int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int numberThree = int.Parse(Console.ReadLine());

if (numberOne > 0 && numberTwo > 0 && numberThree < 0) 
{
    Console.WriteLine("negative");
}
else if (numberOne < 0 && numberTwo < 0 && numberThree > 0)
{
    Console.WriteLine("positive");
}
else
{
    Console.WriteLine("zero");
}
