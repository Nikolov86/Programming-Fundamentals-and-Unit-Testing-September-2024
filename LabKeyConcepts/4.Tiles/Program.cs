//•	You have a rectangular bathroom of size W x H
//•	We want to cover it with tiles of size Wt x Ht
//•	Read four floating-point numbers:
//o First represents bathroom width (W)
//o	Second represents bathroom height (H)
//o	Third represents tile width (Wt)
//o	Forth represents tile height (Ht)
//•	Calculate how many tiles will be needed (add 10% surplus)
//•	Print the count of the needed tiles, rounded to the nearest integer

double bathroomW = double.Parse(Console.ReadLine());
double bathroomH = double.Parse(Console.ReadLine());
double tileWt = double.Parse(Console.ReadLine());
double tileHt = double.Parse(Console.ReadLine());

double bathroomCalc = bathroomW * bathroomH;
bathroomCalc = bathroomCalc + 0.10 * bathroomCalc;

double tileCalc = tileWt * tileHt;
double tilesNeeded = bathroomCalc / tileCalc; 

Console.WriteLine(Math.Round(tilesNeeded));
