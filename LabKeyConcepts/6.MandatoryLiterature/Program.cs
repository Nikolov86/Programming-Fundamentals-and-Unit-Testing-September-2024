//Read 3 lines from the console:
//1.	Number of pages in the current book – an integer in the range [1... 1000].
//2.	Pages that he reads in 1 hour – an integer in the range [1... 1000].
//3.	The number of days he needs to finish the book – an integer in the range [1... 1000].
//Hint: For the operands of integer types, the result of the / operator is of an integer type and equals the quotient of the two operands rounded towards zero.


int numberOfPages = int.Parse(Console.ReadLine());
int readsPagePerHour = int.Parse(Console.ReadLine());
int numberOfDays = int.Parse(Console.ReadLine());

int totalReadingHours = numberOfPages/ readsPagePerHour;
int requiredHours = totalReadingHours / numberOfDays;

Console.WriteLine(requiredHours);