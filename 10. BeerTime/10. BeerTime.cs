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

        if (DateTime.TryParse(inputTime, out time))
        {
            time = DateTime.ParseExact(inputTime, "hh:mm tt", CultureInfo.InvariantCulture);
            Console.WriteLine(time);
        }
        else
        {
            Console.WriteLine("Ti si invalid");
        }
    }
}

