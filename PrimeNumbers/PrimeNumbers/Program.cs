using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Prime();
            }
        }

        static void Prime()
        {
            Console.WriteLine("Write a number to check if it is a prime number!");
            int number;
            bool isInt = int.TryParse(Console.ReadLine(), out number);


            if (isInt && number > 1)
            {
                if (CheckIfNumberIsPrime(number))
                {
                    Console.WriteLine(number + " is a prime number!");
                }
                else
                {
                    Console.WriteLine(number + " is NOT a prime number!");
                }

            }
            else Console.WriteLine("Please enter an integer!");
        }

        static bool CheckIfNumberIsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
