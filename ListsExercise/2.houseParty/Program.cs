namespace _2.houseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCommand = int.Parse(Console.ReadLine());

            List<string> nameList = new List<string>();

            for (int count = 1; count <= inputCommand; count++)
            {
                string command = Console.ReadLine();
                string[] commandParts = command.Split(" ");
                string name = commandParts[0];

                if (commandParts.Length == 3) // Adding a guest
                {
                    if (nameList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        nameList.Add(name);
                    }
                }
                else if (commandParts.Length == 4) // Removing a guest
                {
                    if (nameList.Contains(name))
                    {
                        nameList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            // Print the final list
            foreach (string nameGuest in nameList)
            {
                Console.WriteLine(nameGuest);
            }

        }
    }
}
