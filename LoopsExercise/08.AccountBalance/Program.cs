string input = Console.ReadLine();

decimal balanceIn = 0;
decimal balanceDecrease = 0;
decimal accountBalance = 0;

while (input != "End")
{
    decimal income = decimal.Parse(input); //Convert a string input into a decimal

    if (income > 0)
    {
        balanceIn += income;
        Console.WriteLine($"Increase: {income:F2}");
    }
    else if (income < 0)
    {
        balanceDecrease += Math.Abs(income);
        Console.WriteLine($"Decrease: {Math.Abs(income):F2}");
    }

    input = Console.ReadLine(); //Read user input
}

accountBalance = balanceIn - balanceDecrease;
Console.WriteLine($"Balance: {accountBalance:F2}");
