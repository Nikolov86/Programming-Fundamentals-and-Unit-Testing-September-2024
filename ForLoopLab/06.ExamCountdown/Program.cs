namespace _06.ExamCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayNum = int.Parse(Console.ReadLine());

            for (int i = dayNum; i > 0; i--)
            {
                Console.WriteLine($"{i} days before the exam");
            }
            Console.WriteLine("The exam has come");

        }
    }
}
