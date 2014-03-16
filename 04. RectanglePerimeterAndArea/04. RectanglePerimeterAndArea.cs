using System;

class RectanglePerimeterAndArea
{
    static void Main()
    {
        double rectangleWidth = 2.5;
        double rectangleHeight = 3;
        double rectanglePerimeter = rectangleWidth * rectangleHeight;
        double rectangleArea = (rectangleWidth * 2) + (rectangleHeight * 2);

        Console.WriteLine("The rectangle width is {0} and height is {1}", rectangleWidth, rectangleHeight);
        Console.WriteLine("The perimeter is " + rectanglePerimeter);
        Console.WriteLine("The area is " + rectangleArea);
    }
}

