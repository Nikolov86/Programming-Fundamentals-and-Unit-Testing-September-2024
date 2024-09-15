//1.	Deposited amount – real number in the range [100.00 ... 10000.00]
//2.	Term of the deposit (in months) – an integer in the range [1... 12]
//3.	Annual interest rate – real number in the range [0.00 ... 100.00]
//1.	Deposited amount – real number in the range [100.00 ... 10000.00]
//2.	Term of the deposit (in months) – an integer in the range [1... 12]
//3.	Annual interest rate – real number in the range [0.00 ... 100.00]
//amount = deposited amount + term of deposit * (deposited amount * annual interest rate) / 12amount 

decimal depositedAmount = decimal.Parse(Console.ReadLine());
int termOfDeposit = int.Parse(Console.ReadLine());
decimal interestRate = decimal.Parse(Console.ReadLine()) / 100;


decimal amount = depositedAmount + termOfDeposit * (depositedAmount *  interestRate) / 12;

Console.WriteLine(amount);