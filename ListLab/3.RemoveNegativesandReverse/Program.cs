namespace _3.RemoveNegativesandReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> newList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] < 0)
                {
                    newList.RemoveAt(i);
                    i--; // Adjust the index to account for removal
                }
            }

            newList.Reverse();

            if (newList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else 
            {
                Console.WriteLine(string.Join(", ",newList));
            }
        }
    }
}
