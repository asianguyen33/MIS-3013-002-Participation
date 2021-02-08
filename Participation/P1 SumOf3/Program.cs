using System;

namespace P1_SumOf3
{
    class Program
    {
        static double ClassLevelVariable = 5;

        static void Main(string[] args)
        {
            const double MAGIC_NUMBER = 7.777; // local variable that is a constant

            // Can't do this because it is a cosntant value MAGIC_NUMBER = 8;
            ClassLevelVariable = 8;

            double FirstNumber;
            double SecondNumber;
            double ThirdNumber;

            Console.WriteLine("Please enter first number");
            string answer1 = Console.ReadLine();
            double value1 = Convert.ToDouble(answer1)
            //FirstNumber = Convert.ToDouble(answer1);

            Console.WriteLine("Please enter second number");
            string answer2 = Console.ReadLine();
            SecondNumber = Convert.ToDouble(answer2);

            Console.WriteLine("Please enter third number");
            string answer3 = Console.ReadLine();
            ThirdNumber = Convert.ToDouble(answer3);



            double sum = FirstNumber + SecondNumber + ThirdNumber;

            Console.WriteLine("The result of " + FirstNumber.ToString("N3") + " + " +
               SecondNumber.ToString("N3") + " + " + ThirdNumber.ToString("N3") + " = " + sum.ToString("N3"));


            double product =  sum * MAGIC_NUMBER;

            Console.WriteLine("The result of " + sum.ToString("N") + " * " + MAGIC_NUMBER + " = " + product.ToString("N3"));

            



        }
    }
}
