
int stopNumber = int.Parse(Console.ReadLine());

double sum = 0;
double bonus = 1.20;// ---> 20% •	When the stop number is found, increase the value of the previous number before it with 20% and print it


while (stopNumber > 0) 
{
int number = int.Parse(Console.ReadLine());

    if (number == stopNumber) 
    {
        sum *= bonus; //---> 20% bonus 
        break;  
    }
    sum = number;
    number++;
}
Console.WriteLine(sum);