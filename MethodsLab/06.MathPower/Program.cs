int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

MathPowerNumber( number, power);

static void MathPowerNumber(int number, int power) 
{
    Console.WriteLine(Math.Pow(number, power));
}