using System;

class NumberAsWords
{
    static void Main()
    {
        Console.WriteLine("This program converts an integer number in the range [0...999] to words.");
        Console.WriteLine("Enter integer number in the range [0...999]: ");

        string inputNum = Console.ReadLine();
        int num = 0;
        bool isValid = int.TryParse(inputNum, out num);
        int hundreds = ((num / 100) % 10);
        int decimals = ((num / 10) % 10);
        int units = num % 10;

        while ((!isValid) || (!(num >= 0 && num <= 999)))
        {
            Console.WriteLine("Invalid Number! Enter integer number in the range [0...999]: ");
            inputNum = Console.ReadLine();
            isValid = int.TryParse(inputNum, out num);
        }

        if (hundreds > 0)
        {
            switch (hundreds)
            {
                case 1:
                    Console.Write("one hundred");
                    break;
                case 2:
                    Console.Write("two hundred");
                    break;
                case 3:
                    Console.Write("three hundred");
                    break;
                case 4:
                    Console.Write("four hundred");
                    break;
                case 5:
                    Console.Write("five hundred");
                    break;
                case 6:
                    Console.Write("six hundred");
                    break;
                case 7:
                    Console.Write("seven hundred");
                    break;
                case 8:
                    Console.Write("eight hundred");
                    break;
                case 9:
                    Console.Write("nine hundred");
                    break;
            }
            if (decimals != 0 && units != 0)
            {
                Console.Write(" and ");
            }

        }

        if (decimals >= 2)
        {
            switch (decimals)
            {
                case 2:
                    Console.Write("twenty");
                    break;
                case 3:
                    Console.Write("thirty");
                    break;
                case 4:
                    Console.Write("fourty");
                    break;
                case 5:
                    Console.Write("fifty");
                    break;
                case 6:
                    Console.Write("sixty");
                    break;
                case 7:
                    Console.Write("seventy");
                    break;
                case 8:
                    Console.Write("eighty");
                    break;
                case 9:
                    Console.Write("ninety");
                    break;
            }
            Console.Write(" ");
        }

        if (decimals == 1)
        {
            switch (units)
            {
                case 0:
                    Console.Write("ten");
                    break;
                case 1:
                    Console.Write("eleven");
                    break;
                case 2:
                    Console.Write("twelve");
                    break;
                case 3:
                    Console.Write("thirteen");
                    break;
                case 4:
                    Console.Write("fourteen");
                    break;
                case 5:
                    Console.Write("fifteen");
                    break;
                case 6:
                    Console.Write("sixteen");
                    break;
                case 7:
                    Console.Write("seventeen");
                    break;
                case 8:
                    Console.Write("eighteen");
                    break;
                case 9:
                    Console.Write("nineteen");
                    break;
            }
        }

        if (decimals == 0 || units != 0)
        {
            switch (units)
            {
                case 0:
                    Console.Write("zero");
                    break;
                case 1:
                    Console.Write("one");
                    break;
                case 2:
                    Console.Write("two");
                    break;
                case 3:
                    Console.Write("three");
                    break;
                case 4:
                    Console.Write("four");
                    break;
                case 5:
                    Console.Write("five");
                    break;
                case 6:
                    Console.Write("six");
                    break;
                case 7:
                    Console.Write("seven");
                    break;
                case 8:
                    Console.Write("eight");
                    break;
                case 9:
                    Console.Write("nine");
                    break;
            }
        }
        Console.WriteLine();
    }
}


