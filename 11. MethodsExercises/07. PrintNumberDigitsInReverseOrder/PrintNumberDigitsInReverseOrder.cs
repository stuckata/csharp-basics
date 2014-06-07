using System;

class PrintNumberDigitsInReverseOrder
{
    static void Main()
    {
        Console.WriteLine("This program print digits of entered number in reverse order.");
        Console.WriteLine();

        int num = EnterNumber();
        bool isPositive = CheckPositiveOrNegative(num);
        PrintReverseNumberDigits(num, isPositive);
    }

    static bool CheckPositiveOrNegative(int num)
    {
        bool isPositive = (num >= 0);
        return isPositive;
    }

    static int EnterNumber()
    {
        Console.Write("Please, enter integer number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static void PrintReverseNumberDigits(int num, bool isPositive)
    {
        int lastDigit = 0;
        num = Math.Abs(num);
        string reversedNum = "";

        while (num >= 1 || num <= -1)
        {
            lastDigit = (num % 10);
            reversedNum = reversedNum + lastDigit;
            num = num / 10;
        }
        Console.WriteLine(isPositive ? reversedNum : ("-" + reversedNum));
    }
}

