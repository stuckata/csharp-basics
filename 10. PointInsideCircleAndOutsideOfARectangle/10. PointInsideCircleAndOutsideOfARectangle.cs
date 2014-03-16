using System;

class PointInsideCircleAndOutsideOfARectangle
{
    static void Main()
    {
        double coordinatePointX = 1;
        double coordinatePointY = 2.5;
        int circleCenterX = 1;
        int circleCenterY = 1;
        double circleRadius = 1.5;

        bool pointInACircle = ((coordinatePointX - 1) * (coordinatePointX - 1)
            + (coordinatePointY - 1) * (coordinatePointY - 1)) <= circleRadius * circleRadius;
        bool pointOutOfRectangle = ((coordinatePointX >= -1) && (coordinatePointX <= 5))
            ^ ((coordinatePointY >= -1) && (coordinatePointY <= 1));
        bool pointInACircleAndOutOfRectangle = pointInACircle && pointOutOfRectangle;

        Console.WriteLine("Check if the point with coordinates ({0}, {1}) is within K ((1,1), 1.5) and out of R(top=1, left=-1, width=6, height=2)", coordinatePointX, coordinatePointY);
        Console.WriteLine(pointInACircleAndOutOfRectangle == true ? "Yes" : "No");
    }
}
