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
            bool isPrime = (parsedNumber <= 100) && (byTwo > 0) && (byThree > 0) && (byFive > 0) && (bySeven > 0);
            Console.WriteLine(isPrime);
            double gosho = Math.Sqrt(parsedNumber);
            Console.WriteLine(gosho);
        }
    }
}