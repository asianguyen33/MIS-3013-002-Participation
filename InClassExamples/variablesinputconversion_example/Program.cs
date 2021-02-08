using System;

namespace variablesinputconversion_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int heresmyInt;
            double heresmyDouble;

            Console.WriteLine("Please enter a double");
            String answer = Console.ReadLine();
            heresmyDouble = Convert.ToDouble(answer);

            Console.WriteLine("Please enter a int");
            answer = Console.ReadLine();
            heresmyInt = Convert.ToInt32(answer);

            double result = heresmyDouble + heresmyInt;

            Console.WriteLine("The result of " + heresmyDouble.ToString("N3") + " + " +
                heresmyInt.ToString() + " = " + result.ToString("C5"));
            
        }
    }
}
