using System;

namespace whereIsNumberSeven
{
    class numberSeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your number");
            string yourNumber = Console.ReadLine();
            int yourNumberIsSeven = int.Parse(yourNumber);
            int devidedFirstNumber = (yourNumberIsSeven / 10);
            int devidedSecondNumber = (devidedFirstNumber / 10);
            int thisIsMyCalculation = (devidedSecondNumber % 10);
            string isValueSeven = thisIsMyCalculation == 7 ? "Third value is seven." : "Third value is not seven.";
            Console.WriteLine(isValueSeven);
        }
    }
}
