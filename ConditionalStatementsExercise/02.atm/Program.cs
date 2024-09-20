//•	balance, withdraw and limit
//•	Based on the given input parameters:
//o Print "The withdraw was successful.", if the balance is enough
//o	Print "The limit was exceeded.", if the limit is exceeded
//o	Print "Insufficient availability.", if the balance isn't enough

int balance = int.Parse(Console.ReadLine());
int withdraw = int.Parse(Console.ReadLine());
int limit = int.Parse(Console.ReadLine());

if (balance > withdraw && balance > limit)
{
    Console.WriteLine("The withdraw was successful.");
}
else if (limit > balance && limit < withdraw)
{
    Console.WriteLine("The limit was exceeded.");
}
else 
{
    Console.WriteLine("Insufficient availability.");
}