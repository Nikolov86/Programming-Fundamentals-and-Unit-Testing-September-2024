namespace _01.NumbersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            for (int i = numOne; i <= numTwo; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}