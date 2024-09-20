//•	Reads an hour of the day (integer number) and a day of the week (string)

//•	The office's working hours are from 10 AM to 6 PM, Monday through Saturday, inclusive.

//o	Print "open", if the office is open in the given hour and day of the week
//o	Print "closed", if the office is closed in the given hour and day of the week
int hourOfTheDay = int.Parse(Console.ReadLine());
string dayOfTheWeek = Console.ReadLine();

if ((hourOfTheDay >= 10 && hourOfTheDay <= 18) && dayOfTheWeek != "Sunday") // 6 AM == 18
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}
