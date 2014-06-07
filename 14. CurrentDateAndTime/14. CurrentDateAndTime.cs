using System;

class CurrentDateAndTime
{
    static void Main()
    {
        string dateTime = DateTime.Now.ToString("dd-M-yyyy HH:mm:ss");
        Console.WriteLine("The current Date and Time are: " + dateTime);
    }
}
