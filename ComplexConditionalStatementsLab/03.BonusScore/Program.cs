//•	Add bonus points to given points based on following:
//o If points are between 0 and 3 (inclusive), adds 5 to the given points
//o	If points are between 4 and 6 (inclusive), adds 15 to the given points
//o	If points are between 7 and 9 (inclusive), adds 20 to the given points
//•	Print final points after adding the bonus points


int bonus = int.Parse(Console.ReadLine());

if (bonus <= 0 && bonus <= 3)
{
    Console.WriteLine(bonus + 5);
}
else if (bonus >= 4 && bonus <= 5)
{
    Console.WriteLine(bonus + 15);
}
else if (bonus >= 7 && bonus <= 9) 
{
    Console.WriteLine(bonus + 20);
}