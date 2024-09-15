//•	Read two floating-point numbers: first number and second number
//•	Performs 4 arithmetic operations on the given 2 numbers, in the following order: 
//o Addition(+)
//o Subtraction(-)
//o Multiplication(*)
//o Division(/)
//•	Print the results, all formatted to the 2nd digit,  in the following format:
//o   "{first number} + {second number} = {addition result}"
//o	"{first number} - {second number} = {subtraction result}"
//o	"{first number} * {second number} = {multiplication result}"
//o	"{first number} / {second number} = {division result}"

//Input

using System.Collections.Generic;

double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

////o Addition(+)
double sumOne = firstNumber + secondNumber;

//o Subtraction(-)

double sumTwo = firstNumber - secondNumber;

//o Multiplication(*)

double sumThree = firstNumber * secondNumber;

//o Division(/)

double sumFour = firstNumber / secondNumber;

Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {sumOne:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {sumTwo:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {sumThree:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {sumFour:F2}");
