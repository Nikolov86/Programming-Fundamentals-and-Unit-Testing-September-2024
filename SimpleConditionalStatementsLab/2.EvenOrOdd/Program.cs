namespace _2.EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Reads an integer number
            //•	Check the number
            //o   If it's even, prints "even"
            //o If it's odd, prints "odd"


            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            { 
                Console.WriteLine("even");
            }
            else 
            { 
                Console.WriteLine("odd");
            
            }

        }
    }
}
