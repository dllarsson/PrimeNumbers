using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
[assembly: InternalsVisibleTo("NUnitTest")]
namespace PrimeNumbers 
{
    /*
     * Här är min primechecker klass där alla funktioner för att kolla prime finns.
     */
    public class PrimeChecker
    {
        //Här sparar jag alla primtal i en lista, man kan ha duplicerade primtal i mitt program.
        internal List<int> primeNumbers = new List<int>();

        //Sparar det högsta primtalet som man har prövat. Använder det för att sedan räkna ut nytt högstatal.
        private int currentLargestPrimeNumber = -1;

        //Denna funktion fungerar genom att loopa det högsta årimtalet plus 1 för varje iteraton tills 
        //den hittar nytt primtal. Och då sätter den nya primtalet till currentLargestPrimeNumber och avbryter loopen.
        public void CheckNextPrime()
        {
            int count = 1;
            while (true)
            {
                if (CheckIfNumberIsPrime(currentLargestPrimeNumber + count))
                {
                    primeNumbers.Add(currentLargestPrimeNumber + count);
                    currentLargestPrimeNumber += count;
                    Console.WriteLine("Next largest primenumber is: " + currentLargestPrimeNumber);
                    break;
                }
                count++;
            }
        }

        //En foreachloop som loopar igenom alla primtal som är sparade till min lista, och skriver ut till konsol.
        public string PrintPrimes()
        {
            var printNumber = "";
            Console.Write("Primenumbers: ");
            foreach (var number in primeNumbers)
            {
                printNumber += (number + " ");
            }
            return printNumber;
        }

        //Här tar jag in input från användaren. Jag kollar om input är en int, om det är det så går jag vidare
        // och kollar ifall det är ett primtal eller inte.
        // Om input inte är en int så skriver jag ut att det är fel typ av input.
        // Denna metoden retunerar en string som jag skriver ut ett medelande till konsolen med.
        public string PrimeInput(string input)
        {
            int number;
            bool isInt = int.TryParse(input, out number);


            if (isInt && number > 1)
            {
                if (CheckIfNumberIsPrime(number))
                {
                    primeNumbers.Add(number);
                    if (number > currentLargestPrimeNumber)
                    {
                        currentLargestPrimeNumber = number;
                    }
                    return (number + " is a prime number!");
                }
                else
                {
                    return(number + " is NOT a prime number!");
                }
            }
            else return("Wrong type of input, requires a number. Please try again!");
        }

        //Detta är min funktion som faktiskt kollar om talet är ett primtal eller inte.
        //Om talet är mindre än 2 så är det inte primtal, om talet är jämt delbart med något tal 
        //förutom sig själv så är det inte primtal, annars så är det det och retunerar TRUE.
        internal bool CheckIfNumberIsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
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
