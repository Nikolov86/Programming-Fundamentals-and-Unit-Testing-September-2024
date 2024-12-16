namespace _1.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                string cmdInput = input[0];

                if (cmdInput == "Delete")
                {
                    int elementToDelete = int.Parse(input[1]);
                    firstList.RemoveAll(x => x == elementToDelete); // Remove all occurrences
                }
                else if (cmdInput == "Insert")
                {
                    int elementToInsert = int.Parse(input[1]);
                    int index = int.Parse(input[2]);

                    if (index >= 0 && index <= firstList.Count) // Ensure index is valid
                    {
                        firstList.Insert(index, elementToInsert);
                    }
                }

                input = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", firstList));
        }
    }
}
