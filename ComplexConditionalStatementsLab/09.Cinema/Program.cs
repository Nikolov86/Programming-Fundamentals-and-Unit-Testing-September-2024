
string type = Console.ReadLine();
int countOfRows = int.Parse(Console.ReadLine());
int countOfSeats = int.Parse(Console.ReadLine());

decimal price = 0m;

if (type == "Premiere")
{

    price = 12.00m;
    decimal totalSeats = countOfRows * countOfSeats;
    decimal totalPrice = totalSeats * price;
    Console.WriteLine($"{totalPrice:F2}");
}
else if (type == "Normal")
{
    price = 7.50m;
    decimal totalSeats = countOfRows * countOfSeats;
    decimal totalPrice = totalSeats * price;
    Console.WriteLine($"{totalPrice:F2}");
}
else if (type == "Discount")
{
    price = 5.00m;
    decimal totalSeats = countOfRows * countOfSeats;
    decimal totalPrice = totalSeats * price;
    Console.WriteLine($"{totalPrice:F2}");
}

