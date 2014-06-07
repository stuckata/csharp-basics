using System;

class CalculatingTrapezoidArea
{
    static void Main()
    {
        double sideA = 0.222;
        double sideB = 0.333;
        double height = 0.555;

        double area = ((sideA + sideB) / 2) * height;

        Console.WriteLine("The area of trapezoid with sides {0} and {1}, height {2} is: {3}", sideA, sideB, height, area);
    }
}
