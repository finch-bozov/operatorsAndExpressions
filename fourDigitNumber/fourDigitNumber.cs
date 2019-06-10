using System;

namespace fourDigitNumber
{
    class fourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your four digit number");
            string fourDigits = Console.ReadLine();
            int parsedDigits = short.Parse(fourDigits);
            int gosho = parsedDigits / 1000;
            //string isItFourDigits = parsedDigits / 1000 <= 9 ? "Number is four digits" : "Number is not four digits";
            //Console.WriteLine(isItFourDigits);
            int a = (parsedDigits / 1000);
            int b = (parsedDigits / 100) % 10;
            int c = (parsedDigits / 10) % 10;
            int d = (parsedDigits % 10);
            Console.WriteLine("The reversed number is {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("The last digit in first position is {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("When we switch the second and third digits this is the result {0}{1}{2}{3}", a, c, b, d);
        }
    }
}
