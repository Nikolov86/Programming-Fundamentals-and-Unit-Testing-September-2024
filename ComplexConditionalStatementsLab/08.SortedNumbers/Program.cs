//•	Reads 3 integer numbers from the console 
//•	Based on the order of the numbers, print:
//o   "Ascending" – if the numbers are in ascending order (from the smallest to the largest number)
//o	"Descending" – if the numbers are in descending order (from the largest to the smallest number)

int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int numberThree = int.Parse(Console.ReadLine());

if (numberOne < numberTwo && numberTwo < numberThree)
{
    Console.WriteLine("Ascending");
}
else if (numberOne > numberTwo && numberTwo > numberThree)
{
    Console.WriteLine("Descending");
}
else 
{
    Console.WriteLine("Not sorted"); 
}