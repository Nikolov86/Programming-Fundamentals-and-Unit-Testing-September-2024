using System.Diagnostics.Metrics;

namespace _2.ListofProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<string> listOfProduct = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string product = Console.ReadLine();
                listOfProduct.Add(product);
            }

            listOfProduct.Sort();

            int counter = 1;

            foreach (string product in listOfProduct)
            {
                Console.WriteLine($"{counter}.{product}");
                counter++;
            }

        }
    }
}
