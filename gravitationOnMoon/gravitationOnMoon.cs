using System;

namespace gravitationOnMoon
{
    class gravitationOnMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your weight");
            string myWeight = Console.ReadLine();
            int myWeightParsed = int.Parse(myWeight);
            double result = (myWeightParsed * 0.17);
            Console.WriteLine("Your weight on the moon is: {0}", result);
        }
    }
}
