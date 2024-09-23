namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numInt = int.Parse(Console.ReadLine());
            double num = 0;

            for (int i = 0; i < numInt; i++)
            {
                num += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(num);
        }
    }
}