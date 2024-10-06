
string type = Console.ReadLine();  // input int , char and string


PrintGreaterValues(type);

static void PrintGreaterValues(string type) 
{
    switch (type)
    {

        case "int":
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber >= secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
            break;
        case "string":
            string strOne = Console.ReadLine();
            string strTwo = Console.ReadLine();

            if (string.Compare(strOne, strTwo) > 0)             //the first text is bigger or equal 
            {
                Console.WriteLine(strOne);
            }
            else if (string.Compare(strOne, strTwo) < 0)     // second string is bigger
            {
                Console.WriteLine(strTwo);
            }

            break;
        case "char":
            char firstChar = char.Parse(Console.ReadLine());          //input data
            char secondChar = char.Parse(Console.ReadLine());

            if (firstChar >= secondChar)
            {
                Console.WriteLine(firstChar);
            }
            else
            {
                Console.WriteLine(secondChar);
            }

            break;
    }



}

