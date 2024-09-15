//•	Package of pens - 5.80 lv. 
//•	Package of markers - 7.20 lv. 
//•	Board cleaner - 1.20 BGN (per liter)
//Input
//From the console read 4 numbers:
//•	Number of packages of pens - integer in the range [0...100].
//•	Number of packets of markers - integer in the range [0...100].
//•	Liters of board cleaner - an integer in the range [0... 50].
//•	Discount percentage - integer in the range [0...100].
//•	

using System.Security.Cryptography;

int numberOfPackagesOfPen = int.Parse(Console.ReadLine());
int numberOfPackagesOfMarkers = int.Parse(Console.ReadLine());
int litersOfBoardCleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

decimal packageOfPens = 5.80m;
decimal packageOfMarkers = 7.20m;
decimal boardCleaner = 1.20m;

decimal priceForAllMaterials = (numberOfPackagesOfPen * packageOfPens) + (numberOfPackagesOfMarkers * packageOfMarkers) + (litersOfBoardCleaner * boardCleaner);


decimal diff = discount / 100.0m;
decimal priceAfterDiscount = priceForAllMaterials - (priceForAllMaterials * diff);


Console.WriteLine(priceAfterDiscount);