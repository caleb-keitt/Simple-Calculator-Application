using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number you want to add.");
            string response = Console.ReadLine();

            int number1;
            if (!int.TryParse(response, out number1))
            {
                Console.WriteLine("Invalid Number!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Enter the second number you want to add.");
            response = Console.ReadLine();

            int number2;
            if (!int.TryParse(response, out number2))
            {
                Console.WriteLine("Invalid Number!");
                Console.ReadLine();
                return;
            }

            int total = number1 + number2;
            Console.WriteLine("The sum of " + number1 + " and " + number2 + " is " + (number1 + number2));
        }
    }
}