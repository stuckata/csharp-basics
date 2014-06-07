using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        decimal numX = decimal.Parse(Console.ReadLine());
        decimal numY = decimal.Parse(Console.ReadLine());
        int result = 0;

        if (numX == 0 || numY == 0)
        {
            if (numX == 0 && numY == 0)
            {
                result = 0;
            }
            else if (numX == 0 && numY != 0)
            {
                result = 5;
            }
            else if (numY == 0 && numX != 0)
            {
                result = 6;
            }
        }
        else
        {
            if (numX > 0 && numY > 0)
            {
                result = 1;
            }
            else if (numX < 0 && numY > 0)
            {
                result = 2;
            }
            else if (numX < 0 && numY < 0)
            {
                result = 3;
            }
            else if (numX > 0 && numY < 0)
            {
                result = 4;
            }
        }
        Console.WriteLine(result);
    }
}

