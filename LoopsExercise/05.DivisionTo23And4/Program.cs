
int intNumber = int.Parse(Console.ReadLine());

//need three counters

int countDivideBy2 = 0;
int countDivideBy3 = 0;
int countDivideBy4 = 0;

for (int i = 0; i < intNumber; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    
    if (currentNumber % 2 == 0) 
    {
        countDivideBy2++;
    }
    if (currentNumber % 3 == 0) 
    { 
        countDivideBy3++; 
    }
    if (countDivideBy3 % 4 == 0) 
    { 
        countDivideBy4++; 
    }
    
    
}
double percentDivideBy2 = (double)countDivideBy2 / intNumber * 100;  // cast to double 
double percentDivideBy3 = (double)countDivideBy3 / intNumber * 100;
double percentDivideBy4 = (double)countDivideBy4 / intNumber * 100;

Console.WriteLine($"{percentDivideBy2:F2}%");
Console.WriteLine($"{percentDivideBy3:F2}%");
Console.WriteLine($"{percentDivideBy4:F2}%");