﻿
using System;

class Program
{
    static void Main()
    {
        string product = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        CalculateAndPrintTotalPrice(product, quantity);
    }

    static void CalculateAndPrintTotalPrice(string product, int quantity)
    {
        double price = 0;

        switch (product)
        {
            case "coffee":
                price = 1.50;
                break;
            case "water":
                price = 1.00;
                break;
            case "coke":
                price = 1.40;
                break;
            case "snacks":
                price = 2.00;
                break;
            default:
                Console.WriteLine("Invalid product");
                return;
        }

        double totalPrice = price * quantity;
        Console.WriteLine($"{totalPrice:F2}");
    }
}
