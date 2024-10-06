
//using System.Drawing;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//int countFloors = int.Parse(Console.ReadLine());
//int countEstates = int.Parse(Console.ReadLine());

//string type = "";

//for (int floor = 0; floor < countFloors; floor++)
//{
//    for (int number = 0; number <= countEstates; number++)
//    {

//        if (floor == countFloors)
//        {
//            type = "L";
//            Console.WriteLine($"{type}{floor}{number} ");
//        }
//        else if (countFloors % 2 == 0)
//        {
//            type = "O";
//            Console.WriteLine($"{type}{floor}{number} ");
//        }
//        else 
//        {
//            type = "A";

//            Console.WriteLine($"{type}{floor}{number} ");
//        }
//    }
//    Console.WriteLine();

//}

using System;

int countFloors = int.Parse(Console.ReadLine());
int countEstates = int.Parse(Console.ReadLine());

string type = "";

for (int floor = countFloors; floor >= 1; floor--)
{
    for (int number = 0; number < countEstates; number++)
    {
        if (floor == countFloors )  // Top floor
        {
            type = "L";
        }
        else if (floor % 2 == 0)  // Even floor
        {
            type = "O";
        }
        else  // Odd floor
        {
            type = "A";
        }

        Console.Write($"{type}{floor}{number} ");
    }
    Console.WriteLine();
}
