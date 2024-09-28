

while (true)
{
int n = int.Parse(Console.ReadLine());
    if (n % 2 == 0)
    {
        n++;
    }
    else 
    {
        Console.WriteLine(n);
        break;
    }
}