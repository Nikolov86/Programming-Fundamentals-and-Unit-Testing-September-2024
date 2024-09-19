//o If the character is vowel letter print "Vowel"
//Hint: Vowels letters are: A, a, E, e, I, i, O, o, U, u
//o	If the character is consonant letter print "Consonant"


string letter = Console.ReadLine();

if ((letter == "A" || letter == "a") || (letter == "E" || letter == "e") || (letter == "I" || letter == "i") || (letter == "O" || letter == "o") || (letter == "U" || letter == "u")) 
{
    Console.WriteLine("Vowel");
}
else
{
    Console.WriteLine("Consonant");
}

