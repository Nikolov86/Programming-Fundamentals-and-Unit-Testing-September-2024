﻿List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    string[] commandParts = command.Split();
    string commandName = commandParts[0];

    switch (commandName)
    {
        case "Add":
            int numberToAdd = int.Parse(commandParts[1]);
            numbers.Add(numberToAdd);
            break;

        case "Remove":
            int numberToRemove = int.Parse(commandParts[1]);
            numbers.Remove(numberToRemove);
            break;

        case "RemoveAt":
            int positionToRemove = int.Parse(commandParts[1]);
            numbers.RemoveAt(positionToRemove);
            break;

        case "Insert":
            int numbersToInsert = int.Parse(commandParts[1]);
            int positionToInsert = int.Parse(commandParts[2]);
            numbers.Insert(positionToInsert, numbersToInsert);
            break;
    }

    // Update the command after processing the current one
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
