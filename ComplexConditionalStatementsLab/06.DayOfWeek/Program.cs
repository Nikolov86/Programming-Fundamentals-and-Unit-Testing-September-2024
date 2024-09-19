
//o If the given number is equals to 1 print the first day of the week, which is "Monday"
//o	If the given number is equals to 2 print the second day of the week, which is "Tuesday"
//o	If the given number is equals to 3 print the third day of the week, which is "Wednesday"
//o	If the given number is equals to 4 print the fourth day of the week, which is "Thursday"
//o	If the given number is equals to 5 print the fifth day of the week, which is "Friday"
//o	If the given number is equals to 6 print the sixth day of the week, which is "Saturday"
//o	If the given number is equals to 7 print the seventh day of the week, which is "Sunday"

int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Error");
        break;


}