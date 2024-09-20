int temperature = int.Parse(Console.ReadLine());
string timeOfTheDay = Console.ReadLine();

string outfit = "";
string shoes = "";

if (temperature >= 10 && temperature <= 18)
{
    if (timeOfTheDay == "Morning")
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (timeOfTheDay == "Afternoon" || timeOfTheDay == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}
else if (temperature > 18 && temperature <= 24)
{
    if (timeOfTheDay == "Afternoon")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (timeOfTheDay == "Morning" || timeOfTheDay == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}
else if (temperature >= 25)
{
    if (timeOfTheDay == "Morning")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (timeOfTheDay == "Afternoon")
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
    else
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}

Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
