using NUnit.Framework;
using PrimeNumbers;

namespace NUnitTest
{
    //Här finns mina unittester
    public class Tests
    {

        //Ett test för att kolla om ett tal under 2 inte är prime
        [Test]
        public void TestIfNumbersLessThan2Fails()
        {
            PrimeChecker pc = new PrimeChecker();
            bool isPrime = pc.CheckIfNumberIsPrime(-12);
            Assert.IsFalse(isPrime);
        }
        //Ett test för att kolla om ett primtal(3 i detta fall) är ett primtal
        [Test]
        public void TestIfPrimeIsPrime()
        {
            PrimeChecker pc = new PrimeChecker();
            bool isPrime = pc.CheckIfNumberIsPrime(3);
            Assert.IsTrue(isPrime);
        }
        //Ett test för att kolla att specialtecken hanteras.
        [Test]
        public void TestSpecialCharactersAreHandeled()
        {
            PrimeChecker pc = new PrimeChecker();
            var message = pc.PrimeInput("!_:;23");
            Assert.AreSame(message, "Wrong type of input, requires a number. Please try again!");
        }
        //Ett test för att kolla att primtalen faktiskt sparas ner till en lista
        [Test]
        public void TestThatPrimeIsSavedToList()
        {
            PrimeChecker pc = new PrimeChecker();
            pc.PrimeInput("3");
            pc.PrimeInput("5");
            pc.PrimeInput("6");
            pc.PrimeInput("7");

            Assert.AreEqual(pc.primeNumbers.Count, 3);
        }
        //Ett test för att kolla att funktionen att få fram nästa största primtal funkar
        //När man ger först 5 sedan 3 så ska nästa största bli 7.
        [Test]
        public void TestIfGetNextPrimeNumberGetsTheRightNumber()
        {
            PrimeChecker pc = new PrimeChecker();
            pc.PrimeInput("5");
            pc.PrimeInput("3");
            pc.CheckNextPrime();
            Assert.AreEqual(pc.primeNumbers[2], 7);
            
        }

    }
}