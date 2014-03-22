using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("A beer time is after 1:00 PM and before 3:00 AM. This program allow you to enter a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” ");
        Console.WriteLine();
        Console.WriteLine("Please enter the time in the format shown above: ");

        string inputTime = Console.ReadLine();

        DateTime time;
        string startBeerStr = "01:00 PM";
        string startBeerStrEndPM = "12:59 PM";
        string endBeerStrStartAM = "01:00 AM";
        string endBeerStr = "03:00 AM";

        if (DateTime.TryParseExact(inputTime, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out time))
        {
            time = DateTime.ParseExact(inputTime, "hh:mm tt", CultureInfo.InvariantCulture);
            DateTime startBeerTime = DateTime.ParseExact(startBeerStr, "hh:mm tt", CultureInfo.InvariantCulture);
            DateTime startBeerTimeEndPM = DateTime.ParseExact(startBeerStrEndPM, "hh:mm tt", CultureInfo.InvariantCulture);
            DateTime endBeerTimeStartAM = DateTime.ParseExact(endBeerStrStartAM, "hh:mm tt", CultureInfo.InvariantCulture);
            DateTime endBeerTime = DateTime.ParseExact(endBeerStr, "hh:mm tt", CultureInfo.InvariantCulture);

            Console.WriteLine(time);
            Console.WriteLine(startBeerTime);
            Console.WriteLine(startBeerTimeEndPM);

            if ((time >= startBeerTime && time <= startBeerTimeEndPM) || (time >= endBeerTimeStartAM && time <= endBeerTime))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }            
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}

