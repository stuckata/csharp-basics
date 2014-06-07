using System;
using System.Globalization;
using System.Threading;

class Triangle
{
    static void Main()
    {
        System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";

        System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        double coordinateAX = double.Parse(Console.ReadLine());
        double coordinateAY = double.Parse(Console.ReadLine());
        double coordinateBX = double.Parse(Console.ReadLine());
        double coordinateBY = double.Parse(Console.ReadLine());
        double coordinateCX = double.Parse(Console.ReadLine());
        double coordinateCY = double.Parse(Console.ReadLine());
        double c = Math.Sqrt((Math.Pow((coordinateBX - coordinateAX), 2) + Math.Pow((coordinateBY - coordinateAY), 2)));
        double b = Math.Sqrt((Math.Pow((coordinateCX - coordinateAX), 2) + Math.Pow((coordinateCY - coordinateAY), 2)));
        double a = Math.Sqrt((Math.Pow((coordinateBX - coordinateCX), 2) + Math.Pow((coordinateBY - coordinateCY), 2)));
        double perimeter = a + b + c;
        double area = 0;
        double halfP = 0;

        if ((((a + b) > c) && ((b + c) > a)) && ((a + c) > b))
        {
            Console.WriteLine("Yes");

            
            halfP = (perimeter / 2);

            area = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));

            Console.WriteLine("{0:0.00}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}", c);
        }
    }
}

