//•	Protective nylon - 1.50 BGN per square meter
//•	Paint - 14.50 BGN per liter
//•	Paint thinner - 5.00 BGN per liter
//Just in case, to the necessary materials, Rumen wants to add another 10% of the amount of paint and 2 square meters of nylon, also 0.40 leva for bags. The amount paid to the craftsmen for 1 hour of work is equal to 30% of the sum of all material costs. 
//Input
//The input is read from the console and contains exactly 4 lines:
//1.	Required amount of nylon (in sq.m.) - an integer number in the range [1... 100]
//2.	Required amount of paint (in liters) - an integer number in the range [1... 100]
//3.	Quantity of thinner (in liters) - integer number in the range [1... 30]
//4.	Hours needed for the craftsmen to do the work - an integer number in the range [1... 9]

int amountOfNylon = int.Parse(Console.ReadLine());
int amountOfPaint = int.Parse(Console.ReadLine());
int quantityOfThinner = int.Parse(Console.ReadLine());
int hoursForCraftsmen = int.Parse(Console.ReadLine());

double protectiveNylon = 1.50;
double paint = 14.50; // in litter
double paintThinner = 5.00;
double bagPrice = 0.40;

double amountForMaterials = (amountOfNylon + 2) * protectiveNylon + (amountOfPaint + (amountOfPaint * 0.10)) * paint + (quantityOfThinner * paintThinner) + bagPrice;

double amountForCraftsmen = (amountForMaterials * 0.30) * hoursForCraftsmen;

double totalAmout = amountForMaterials + amountForCraftsmen;


Console.WriteLine(totalAmout);
