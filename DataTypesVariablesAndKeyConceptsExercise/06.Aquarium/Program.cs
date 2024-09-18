//1.	Length in cm – an integer number in the range [10 ... 500].
//2.	Width in cm – an integer number in the range [10 ... 300].
//3.	Height in cm – an integer number in the range [10... 200].
//4.	Percentage – floating point number in the range [0.000 ... 100.000].
//•	the liters of water that the aquarium will collect, formatted to the second decimal place.

int lengthInCm = int.Parse(Console.ReadLine());
int widthInCm = int.Parse(Console.ReadLine());
int heigthInCm = int.Parse(Console.ReadLine());
decimal percentage = decimal.Parse(Console.ReadLine());

decimal volumeOftheAquarium = lengthInCm * widthInCm * heigthInCm;

decimal volumeInLiters = volumeOftheAquarium / 1000.0m; // 1l = 1dm3

decimal requiredLiters = volumeInLiters * (1 - percentage / 100);

Console.WriteLine($"{requiredLiters:F2}");





