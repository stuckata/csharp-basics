using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.WriteLine("This program calculates the difference between two different dates in days.");
        Console.WriteLine();
        PrintInputConditions();
        DateTime startDate = ValidateInputStartDate();
        DateTime endDate = ValidateInputEndDate();
        CalculateDifferenceInDays(startDate, endDate);
    }

    static void PrintInputConditions()
    {
        Console.WriteLine("Enter dates in format \"dd.MM.yyyy:\" ");
    }

    static void PrintInvalidInput()
    {
        Console.WriteLine("Invalid number!");
    }

    static DateTime ValidateInputStartDate()
    {
        string inputStartDate = Console.ReadLine();
        DateTime startDate;
        bool isValidDate = DateTime.TryParse(inputStartDate, out startDate);
        while (!isValidDate)
        {
            PrintInvalidInput();
            PrintInputConditions();
            inputStartDate = Console.ReadLine();
            isValidDate = DateTime.TryParse(inputStartDate, out startDate);
        }
        return startDate;
    }

    static DateTime ValidateInputEndDate()
    {
        string inputEndDate = Console.ReadLine();
        DateTime endDate;
        bool isValidDate = DateTime.TryParse(inputEndDate, out endDate);
        while (!isValidDate)
        {
            PrintInvalidInput();
            PrintInputConditions();
            inputEndDate = Console.ReadLine();
            isValidDate = DateTime.TryParse(inputEndDate, out endDate);
        }
        return endDate;
    }

    static void CalculateDifferenceInDays (DateTime startDate, DateTime endDate)
    {
        TimeSpan difference = endDate - startDate;
        if (startDate > endDate)
        {
            Console.WriteLine("The difference in days is : -{0:%d}", difference);
        }
        else
        {
            Console.WriteLine("The difference in days is : {0:%d}", difference);
        }
    }
}

