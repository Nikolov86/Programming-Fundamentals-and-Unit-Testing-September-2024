
using System.Diagnostics;
using System.Diagnostics.Metrics;

int sumNVowels = int.Parse(Console.ReadLine());
int sum = 0;
int result = 0;

for (int i = 0; i < sumNVowels; i++)
{
    string letter = Console.ReadLine();

    switch (letter)
    {
        case "a":sum = +1;break;
        case "e":sum = +2;break;
        case "i":sum = +3;break;
        case "o":sum = +4;break;
        case "u":sum = +5;break;

        default:sum = 0;break;

    }

   result += sum;
}
Console.WriteLine(result);
