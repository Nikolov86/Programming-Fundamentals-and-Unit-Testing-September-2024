
//input number power Don`t use Math.Paw only loop

int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

int sum = 1; 

for (int i = 0; i < power; i++)
{
    
    sum *= number;
    
}
Console.WriteLine(sum);

Console.WriteLine("===================================================");

int result = (int)Math.Pow(number, power); //If you need the result to be an integer, you can cast it to int.
Console.WriteLine(result);
