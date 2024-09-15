
//•	You have a farmer sells tomatoes and cucumbers at the market
//•	Read four floating-point numbers:
//o First represents tomato price
//o	Second represents tomato quantity
//o	Third represents cucumber price
//o	Forth represents cucumber quantity
//•	Calculate the total cost of the production by given quantities and prices
//•	Print the total cost, formatted to the 2nd digit


decimal tomatoPrice = decimal.Parse(Console.ReadLine());
decimal tomatoQuantity = decimal.Parse(Console.ReadLine());
decimal cucumberPrice = decimal.Parse(Console.ReadLine());
decimal cucumberQuantity = decimal.Parse(Console.ReadLine());

decimal totalCost = (tomatoPrice * tomatoQuantity) + (cucumberPrice * cucumberQuantity);

Console.WriteLine($"{totalCost:F2}");