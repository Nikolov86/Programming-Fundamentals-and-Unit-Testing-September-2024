using System.Security.Cryptography;

namespace _1.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listToChenge = Console.ReadLine().Split(" ").Select(int.Parse).ToList(); // Read the input data

            string inputCommand = Console.ReadLine(); // Read the initial command

            while (inputCommand != "end")
            {
                string[] commandValue = inputCommand.Split(" ");
                string commandName = commandValue[0];

                if (commandName == "Delete")
                {
                    int commandToDelete = int.Parse(commandValue[1]);

                    // Remove all occurrences of the given number
                    while (listToChenge.Contains(commandToDelete))
                    {
                        listToChenge.Remove(commandToDelete);
                    }
                }
                else if (commandName == "Insert")
                {
                    int elementToInsert = int.Parse(commandValue[1]);
                    int index = int.Parse(commandValue[2]);

                    if (index >= 0 && index <= listToChenge.Count) // Ensure valid index
                    {
                        listToChenge.Insert(index, elementToInsert);
                    }
                }

                inputCommand = Console.ReadLine(); // Read the next command
            }

            Console.WriteLine(string.Join(" ", listToChenge));
        }
    }
}
