string product = Console.ReadLine();
//"banana", "apple", "kiwi", "cherry" or "lemon" you have to print "fruit"
//following "cucumber", "pepper" or "carrot" you have to print "vegetable"
if (product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon")
{
    Console.WriteLine("fruit");
}
else if (product == "cucumber" || product == "pepper" || product == "carrot")
{
    Console.WriteLine("vegetable");
}
else 
{
    Console.WriteLine("unknown");
}
