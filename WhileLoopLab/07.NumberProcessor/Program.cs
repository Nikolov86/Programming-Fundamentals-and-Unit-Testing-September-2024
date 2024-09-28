
int numbers = int.Parse(Console.ReadLine());


while (numbers > 0) 
{
    string command = (Console.ReadLine());
    if (command == "Inc")
    {
        numbers++; //Increments the numeber
  
    }
    else if (command == "Dec")
    {
        numbers--;//Decrements the number
    }
    else if (command == "End") 
    {
        Console.WriteLine(numbers); // exit the loop
        break;
    }
}  
