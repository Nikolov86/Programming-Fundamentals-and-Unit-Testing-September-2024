namespace _07.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letterOne = char.Parse(Console.ReadLine());
            char letterTwo = char.Parse(Console.ReadLine());

            // Check if the input letters are within the valid lowercase range
            if (letterOne >= 'a' && letterTwo <= 'z' || letterOne >= 'A' && letterTwo <= 'Z')
            {
                for (char ch = letterOne; ch <= letterTwo; ch++)
                {
                    Console.Write(ch + " ");
                }
            }
        }
    }
}
