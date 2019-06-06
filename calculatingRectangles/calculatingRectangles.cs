using System;

namespace calculatingRectangles
{
    class calculatingRectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in the width of the rectangle: ");
            string rectangleWidth = Console.ReadLine();
            Console.WriteLine("Type in the height of the rectangle: ");
            string rectangleHeight = Console.ReadLine();
            int rectWidthParsed = int.Parse(rectangleWidth);
            int rectHeightParsed = int.Parse(rectangleHeight);
            int perimeterRectangle = (2 * (rectWidthParsed + rectHeightParsed));
            int areaRectangle = (rectWidthParsed * rectHeightParsed);
            Console.WriteLine("The perimeter of the rectangle is: {0}", perimeterRectangle);
            Console.WriteLine("The area of the rectangle is: {0}", areaRectangle);
        }
    }
}
