using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ///////////////////////// Basic Conditionals//////////////////////////
            int rings = 5;
            if (rings >= 5)
            {
                Console.WriteLine("You are welcome to join the party");
            }
            else if (rings > 2)
            {
                Console.WriteLine("Decent...but {0} rings aren't enough", rings);
            }
            else
            {
                Console.WriteLine("Go win some more rings");
            }
            Console.WriteLine("****************");

            /////////////////////Logical Operators//////////////////////////////////////
            int party_rings = 3;
            //By placing the keyword const in front of a variable declaration
            //you establish it as constant and immutable
            string name = "Kobe";
            if (party_rings >= 3 && name == "Kobe")
            {
                Console.WriteLine("Welcome to the party {0}, congratulations on your {1} party_rings", name, party_rings);
            }
        }
    }
}
