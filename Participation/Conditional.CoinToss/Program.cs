using System;

namespace Conditional.CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DEVELOPER_INFO = "Asia Nguyen";

            Console.WriteLine("Guess 'heads' or 'tails'");
            string guess = Console.ReadLine();
            guess = guess.ToLower();

            Random rand = new Random();
            int randomNbr = rand.Next(1, 3); //generated random # btwn 1 and 2
            Console.WriteLine($"{randomNbr}");
            
            //convert their guess to an int or our int to a string 'heads' or 'tails' hint: conditionals

            
                     
            if (randomNbr == 1)
            {
                Console.WriteLine(randomNbr.ToString("heads"));
                //Console.WriteLine("heads");
            }
            else if (randomNbr == 2)
            {
                Console.WriteLine(randomNbr.ToString("tails"));
                //Console.WriteLine("tails");
            }

            //tell the user if they guessed correctly or not hint:conditionals

            if (randomNbr == 1
                && guess == "heads")

            {
                Console.WriteLine("Your guess was correct!");
            }
            else if (randomNbr == 1
                && guess == "tails")
            {
                Console.WriteLine("Your guess was incorrect.");
            }
            else if (randomNbr == 2
                && guess == "tails")
            {
                Console.WriteLine("Your guess was correct!");
            }
            else if (randomNbr == 2
                && guess == "tails")
            {
                Console.WriteLine("Your guess was incorrect.");
            }
            //Output developer info

            Console.WriteLine($"Developed by {DEVELOPER_INFO}.");

        }
    }
}
