using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Hello, this program will help you with simply calculation.\n" +
                "Write your first number, symbol of action and second number. Next push ENTER");
            
            string equal = Console.ReadLine();

            bool isLetter = !String.IsNullOrEmpty(equal) && Char.IsLetter(equal[0]);
            if (isLetter==true)
            {
                Console.WriteLine("Error. Your first char is letter or empty field.Try again.");
                Console.ReadKey();
            }

            
            bool firstisSymbol = Char.IsSymbol(equal[0]);
            if (firstisSymbol==true)
            {
                Console.WriteLine("Error. Your first char is symbol.Try again.");
                Console.ReadKey();
            }

            bool lastisSymbol = Char.IsSymbol(equal[(equal.Length) - 1]);
            if (lastisSymbol == true)
            {
                Console.WriteLine("Error. Your last char is symbol.Try again.");
                Console.ReadKey();
            }

            int x = 0;
            if (isLetter == false && firstisSymbol == false && lastisSymbol == false)
            {
                for (int i = 1; i <= equal.Length; i++)
                {
                    if (equal[i - 1] == '+' || equal[i - 1] == '-' || equal[i - 1] == '*' || equal[i - 1] == '/')
                    {
                        x++;
                    }

                    if (i == equal.Length && x>1)
                    {
                        Console.WriteLine("Error. You put " + x + " times symbol from group + , - , * ,  / \n" +
                            "Try again");
                        Console.ReadKey();
                    }
                }
            }
            
            if (equal.Contains("+")== true)
            {
                string[] equal1 = equal.Split('+');
                int result = Int32.Parse(equal1[0]) + Int32.Parse(equal1[1]);
                Console.WriteLine(result);
            }
            if (equal.Contains("-") == true)
            {
                string[] equal1 = equal.Split('-');
                int result = Int32.Parse(equal1[0]) - Int32.Parse(equal1[1]);
                Console.WriteLine(result);
            }
            if (equal.Contains("*") == true)
            {
                string[] equal1 = equal.Split('*');
                int result = Int32.Parse(equal1[0]) * Int32.Parse(equal1[1]);
                Console.WriteLine(result);
            }
            if (equal.Contains("/") == true)
            {
                string[] equal1 = equal.Split('/');
                int result = Int32.Parse(equal1[0]) / Int32.Parse(equal1[1]);
                Console.WriteLine(result);
            }
            Console.ReadKey();


            





        }
    }    
}
