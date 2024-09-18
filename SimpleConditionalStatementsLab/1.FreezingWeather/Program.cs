//•	Reads an integer number (temperature in Celsius)
//•	Checks whether the temperature is below zero
//•	Prints "Freezing weather!", if the temperature is equal or smaller than 0

int temperature = int.Parse(Console.ReadLine());

if (temperature <= 0) 
{ 
    Console.WriteLine("Freezing weather!"); 

}
