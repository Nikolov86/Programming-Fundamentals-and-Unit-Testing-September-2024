namespace _5.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOddDigits(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOddDigits(int num)
        {
            int sumEven = 0;
            int sumOdd = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;

                if (lastDigit % 2 == 0)
                {
                    sumEven += lastDigit;
                }
                else
                {
                    sumOdd += lastDigit;
                }

                num /= 10;
            }

            return sumEven * sumOdd;
        }
    }
}