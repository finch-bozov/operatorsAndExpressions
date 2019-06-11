using System;

namespace primeNumberCheck
{
    class primeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the number which you want to check here");
            string notParsedNumber = Console.ReadLine();
            int parsedNumber = int.Parse(notParsedNumber);
            bool lessThanHundo = parsedNumber <= 100;
            int byTwo   = parsedNumber % 2;
            int byThree = parsedNumber % 3;
            int byFive  = parsedNumber % 5;
            int bySeven = parsedNumber % 7;
            bool isPrime = ((parsedNumber == 2) || (parsedNumber == 3) || (parsedNumber == 5) || (parsedNumber == 7)) || ((byTwo > 0) && (byThree > 0) && (byFive > 0) && (bySeven > 0));
            bool isPrimeVlado = (parsedNumber % 2 != 0 && parsedNumber != 1 && parsedNumber > 0 && parsedNumber < 101);
            Console.WriteLine(isPrime);
            //Console.WriteLine(isPrimeVlado);
        }
    }
}