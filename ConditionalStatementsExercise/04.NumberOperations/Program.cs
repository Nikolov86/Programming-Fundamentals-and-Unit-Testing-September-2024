//•	Reads 2 real numbers and math operator (string) from the console
//•	Possible given values for the math operator are: "+", "-", "*", "/"
//•	Apply the operator with given numbers
//•	Print output in the following format, where result is formatted to the second digit:
//"{N1} {operator} {N2} = {result}"


int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
string oper = Console.ReadLine();


if (oper == "+")
{
    double result = numberOne + numberTwo;

    Console.WriteLine($"{numberOne} {oper} {numberTwo} = {result:F2}");
}
else if (oper == "-")
{
    double result = numberOne - numberTwo;
    Console.WriteLine($"{numberOne} {oper} {numberTwo} = {result:F2}");
}
else if (oper == "*")
{
    double result = numberOne * numberTwo;
    Console.WriteLine($"{numberOne} {oper} {numberTwo} = {result:F2}");
}
else
{
    double result = numberOne / numberTwo;
    Console.WriteLine($"{numberOne} {oper} {numberTwo} = {result:F2}");
}
