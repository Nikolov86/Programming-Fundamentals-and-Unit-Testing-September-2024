
//•	Reads a string that represents a password
//•	Prints:
//o   "Welcome" if the password is "s3cr3t!"
//o	"Wrong password!" in all other cases 

string password = Console.ReadLine();

if (password == "s3cr3t!")
{
    Console.WriteLine("Welcome");
}
else 
{
    Console.WriteLine("Wrong password!");
}