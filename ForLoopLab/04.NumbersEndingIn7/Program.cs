using System.Data;

namespace _04.NumbersEndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 7; i <= num; i += 10) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
