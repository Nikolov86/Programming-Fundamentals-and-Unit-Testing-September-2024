
int dayNumber = int.Parse(Console.ReadLine());


string[] dayOfWeek = new string[7] {
 "Monday",
 "Tuesday",
 "Wednesday",
 "Thurstday",
  "Friday",
 "Saturday",
"Sunday"};

if (dayNumber >= 1 && dayNumber <= 7) //condition 1 until 7 
{
    Console.WriteLine(dayOfWeek[dayNumber - 1]);  // accessing the element from index 0
}
else 
{
    Console.WriteLine("Invalid day!");
}