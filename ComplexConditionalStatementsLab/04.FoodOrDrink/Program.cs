//o If product is one of following "curry", "noodles", "sushi", "spaghetti" or "bread" you have to print "food"
//o	If product is one of following "tea", "water", "coffee" or "juice" you have to print "drink"
//o	If the product is different from listed products above, print "unknown"







using System.ComponentModel.Design;

string product = Console.ReadLine();

if (product == "curry" || product == "noodles" || product == "sushi" || product == "spaghetti" || product == "bread")
{
    Console.WriteLine("food");
}
else if (product == "tea" || product == "water" || product == "coffee" || product == "juice")
{
    Console.WriteLine("drink");
}
else 
{
    Console.WriteLine("unknown");
}