namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> names = new List<string>();// create new string list

            names.Add("Niki"); // add method string - index 0
            names.Add("Vili"); // index 1
            names.Add("Lili"); // index 2

            foreach (string name in names) 
            {
                Console.Write($"{name} "); // print all string in list
            }
            
            Console.WriteLine(string.Join(" ",names)); //print all string in list
        
            List<string> firstList = new List<string>() {"Viki", "Ico", "Plami" }; // add elements in list 

            //Console.WriteLine(names.Count);  // How many elements do we have on the list?

            
            firstList.Remove("Viki"); // remove method

            Console.WriteLine(string.Join(" ", firstList));
            //Console.WriteLine(firstList.Count);
        }
    }
}
