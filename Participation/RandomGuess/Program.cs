using System;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            int MinimumNum;
            Console.WriteLine("Please enter minimum number");
            string answer = Console.ReadLine();

            while (int.TryParse(answer, out MinimumNum) == false) 
            {
                Console.WriteLine("Sorry that is not a valid input. Please input an interger");
                answer = Console.ReadLine();
            }

            int MaxNum;
            Console.WriteLine("Please enter maximum number");
            answer = Console.ReadLine();

            while (int.TryParse(answer, out MaxNum) == false)
            {
                Console.WriteLine("Sorry that is not a valid input. Please input an interger");
                answer = Console.ReadLine();
            }


            Random rand = new Random();
            int RandomNbr = rand.Next(MinimumNum, MaxNum);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{RandomNbr}");
            Console.ForegroundColor = ConsoleColor.White;
       
            int UserGuess = 0;
            do
            {
                Console.WriteLine($"Guess what the random number will be between {MinimumNum} and {MaxNum}");
                UserGuess = Convert.ToInt32(Console.ReadLine());
                if (UserGuess != RandomNbr)
                {
                    Console.WriteLine("Incorrect, Please try Again.");
                }
                

            } while (UserGuess != RandomNbr);
            Console.WriteLine("You Guessed Correcctly!");
               


        }
    }
}
