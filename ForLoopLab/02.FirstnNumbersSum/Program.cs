namespace _02.FirstnNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumNum = 1;
            string result = "1"; // Start the result with "1" since the first number is 1

            for (int i = 2; i <= n; i += 1)
            {
                sumNum += i;
                result += "+" + i; // Add each number to the result string
            }

            result += "=" + sumNum; // Add the total sum at the end
            Console.WriteLine(result); // Print the final result in one line

        }
    }
}
