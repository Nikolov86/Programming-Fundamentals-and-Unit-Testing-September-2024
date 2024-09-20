//•	Read three integers - the athletes' times in seconds, from console
//•	 Calculate their total time in the format "minutes:seconds"
//Note: The seconds should be displayed with leading zero (2 as "02", 7 as "07", 35 as "35").

int timeOne = int.Parse(Console.ReadLine());
int timeTwo = int.Parse(Console.ReadLine());
int timeThree = int.Parse(Console.ReadLine());

int sumSeconds = timeOne + timeTwo + timeThree;
int minutes = sumSeconds / 60;

int remainingSeconds = sumSeconds % 60;

switch (remainingSeconds)
{
    case < 10:

        Console.WriteLine($"{minutes}:0{remainingSeconds}");
        break;

     default:
        Console.WriteLine($"{minutes}:{remainingSeconds}");
        break;  
}
