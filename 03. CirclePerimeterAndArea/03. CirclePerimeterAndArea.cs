using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("To calculate circle perimeter and area, please enter radius \"r\":");
        double circleR = double.Parse(Console.ReadLine());
        double circleA = Math.PI * circleR * circleR;
        double circleP = 2 * Math.PI * circleR;
        Console.WriteLine("The Circle Radius is: {0:0.00}, Circle Area: {1:0.00} and Circle Perimeter is: {2:0.00}", circleR, circleA, circleP);
    }
}