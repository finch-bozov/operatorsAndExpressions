using System;

class oddOrEvenIntegers
{
    static void Main()
    {
        string askUserInp = "Input your number here: ";
        Console.WriteLine(askUserInp);

        string waitUserInput = Console.ReadLine();
        int userInteger = int.Parse(waitUserInput);
        int devision = userInteger % 2;

        string isEven = devision == 0 ? "The number is even" : "The number is odd";

        Console.WriteLine(isEven);
        //Console.WriteLine(isEven(userInteger) ? "Even" : "Odd");

/*        Boolean isEven(int given)
        {
            return given % 2 == 0;
        }*/
        // this is Mickey's method which works as well
    }    
}
