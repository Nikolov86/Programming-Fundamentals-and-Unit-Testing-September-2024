using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        PrintVowelsCount(text); // Calling the method
    }

    static void PrintVowelsCount(string text)
    {
        int sumVowels = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];

            // Check if the character is a vowel (either upper or lower case)
            if (currentChar == 'A' || currentChar == 'a' ||
                currentChar == 'E' || currentChar == 'e' ||
                currentChar == 'I' || currentChar == 'i' ||
                currentChar == 'O' || currentChar == 'o' ||
                currentChar == 'U' || currentChar == 'u')
            {
                sumVowels++; // Increment the vowel count
            }
        }

        // Output the final result after the loop
        Console.WriteLine(sumVowels);
    }
}
