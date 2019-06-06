using System;

    class divisionByFiveAndSeven
    {
        static void Main()
        {
            string userInupt = Console.ReadLine();
            int parsedUserInput = int.Parse(userInupt);
            int inputByFive = (parsedUserInput % 5);
            int inputBySeven = (parsedUserInput % 7);
            int referenceInt = 0;
             
            bool resultFive = inputByFive == referenceInt;
            bool resultSeven = inputBySeven == referenceInt;

            bool finalResult = resultFive && resultSeven;
            Console.WriteLine(finalResult);
        }
    }