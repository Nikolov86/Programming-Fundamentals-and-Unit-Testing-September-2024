int number = int.Parse(Console.ReadLine());

switch (number)
{
    case < 0:
        Console.WriteLine("negative");
        break;

    case > 0:
        Console.WriteLine("positive");
        break;
    case 0:
        Console.WriteLine("zero");
        break;
}