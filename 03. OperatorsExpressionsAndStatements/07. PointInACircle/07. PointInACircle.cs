using System;

class PointInACircle
{
    static void Main()
    {
        double coordinateX = -1.5;
        double coordinateY = -1.5;
        int circleRadius = 2;

        // the equation is a*a + b*b = c*c where c is radius of the circle
        double squareSum = (coordinateX * coordinateX) + (coordinateY * coordinateY);

        Console.WriteLine((squareSum > circleRadius * circleRadius) ?
            "The point is out of the circle." : "The point is in the circle.");
    }
}