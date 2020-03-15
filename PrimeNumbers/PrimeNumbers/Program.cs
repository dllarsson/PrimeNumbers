using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        //Nytt primechecker object där jag kan köra alla mina funktioner.
        public static PrimeChecker pc = new PrimeChecker();
        static void Main(string[] args)
        {
            //Loopar så att man kan fortsätta få val i programet om vad man vill göra.
            while (true)
            {
                Menu();
            }
        }

        //Denna metod hanterar användar input som sedan bestämmer vad programmet ska göra.
        //alla menyvalen har jag beskrivit i PrimeChecker klassen
        private static void Menu()
        {
            Console.WriteLine("Press 1 to check for primenumber");
            Console.WriteLine("Press 2 to check to print all primenumbers");
            Console.WriteLine("Press 3 to check get next prime after highest prime in your list");
            Console.WriteLine("Press 4 to exit");

            var choice = Console.ReadLine();
            Console.Clear();


            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter a number: ");
                    Console.WriteLine(pc.PrimeInput(Console.ReadLine()));
                    break;
                case "2":
                    Console.WriteLine(pc.PrintPrimes());
                    break;
                case "3":
                    pc.CheckNextPrime();
                    break;
                case "4":
                    Environment.Exit(0); //Avslutar applikationen
                    break;
            }
        }

    }
}
