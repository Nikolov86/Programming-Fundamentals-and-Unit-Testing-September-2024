//•	From the console read: season(string), accommodation type(string) and count of the days (integer)
//o	Season will be one of the following: "Spring", "Summer", "Autumn" and "Winter"
//o	Accommodation type will be one of the following: "Hotel" and "Camping
//•	Based on the table below, you have to calculate expenses for the vacation with the given accommodation type, season and count of the days. 
//•	For the calculation: use price per night (extracted from the table below) multiplied by count of the days.
//•	Print the total expenses, formatted to the second digit after the decimal point

using System.ComponentModel.Design;

string season = Console.ReadLine();
string accommodation = Console.ReadLine();
int countOfDays = int.Parse(Console.ReadLine());


if (season == "Winter" && accommodation == "Hotel")
{
    decimal discount = 0.10m;
    decimal pricePerNigth = 40m;

    decimal expenses = countOfDays * pricePerNigth;
    decimal totalExpenses = expenses - (expenses * discount);

    Console.WriteLine($"{totalExpenses:F2}");

}
else if (season == "Winter" && accommodation == "Camping")
{
    decimal discount = 0.10m;
    decimal pricePerNigth = 10m;

    decimal expenses = countOfDays * pricePerNigth;
    decimal totalExpenses = expenses - (expenses * discount);

    Console.WriteLine($"{totalExpenses:F2}");

}
if (season == "Autumn" && accommodation == "Hotel")
{
    decimal discount = 0.30m;
    decimal pricePerNigth = 20m;

    decimal expenses = countOfDays * pricePerNigth;
    decimal totalExpenses = expenses - (expenses * discount);

    Console.WriteLine($"{totalExpenses:F2}");
}
else if (season == "Autumn" && accommodation == "Camping")
{
    decimal discount = 0.30m;
    decimal pricePerNigth = 15m;

    decimal expenses = countOfDays * pricePerNigth;
    decimal totalExpenses = expenses - (expenses * discount);

    Console.WriteLine($"{totalExpenses:F2}");
}
if (season == "Spring" && accommodation == "Hotel")
{
    decimal discount = 0.20m;
    decimal pricePerNigth = 30m;

    decimal expenses = countOfDays * pricePerNigth;
    decimal totalExpenses = expenses - (expenses * discount);

    Console.WriteLine($"{totalExpenses:F2}");
}
else if (season == "Spring" && accommodation == "Camping")
{
    decimal discount = 0.20m;
    decimal pricePerNigth = 10m;

    decimal expenses = countOfDays * pricePerNigth;
    decimal totalExpenses = expenses - (expenses * discount);

    Console.WriteLine($"{totalExpenses:F2}");
}
if (season == "Summer" && accommodation == "Hotel")
{
    
    decimal pricePerNigth = 50m;
    decimal totalExpenses = countOfDays * pricePerNigth;

    Console.WriteLine($"{totalExpenses:F2}");
}
else if (season == "Summer" && accommodation == "Camping")
{

    decimal pricePerNigth = 30m;
    decimal totalExpenses = countOfDays * pricePerNigth;

    Console.WriteLine($"{totalExpenses:F2}");
}