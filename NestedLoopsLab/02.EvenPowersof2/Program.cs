int number = int.Parse(Console.ReadLine());

for (int i = 0; i <= number; i += 2) // To change odd : i = 0  should be i = 1 
{
    Console.WriteLine($"{Math.Pow(2, i)}");
}