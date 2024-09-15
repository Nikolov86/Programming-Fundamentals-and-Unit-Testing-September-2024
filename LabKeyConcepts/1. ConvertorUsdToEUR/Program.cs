//•	Read a floating-point number: the dollars to be converted 
//•	Convert dollars to euro (use fixed rate of dollars to euro: 0.88)
//•	Print the converted value in euro formatted to the 2nd digit

decimal dollars = decimal.Parse(Console.ReadLine());

decimal changeCourse = 0.88m;

decimal dollarsToEuro = dollars * changeCourse;

Console.WriteLine($"{dollarsToEuro:F2}");
