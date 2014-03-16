using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        int number = 0;
        int divideFive = (number % 5);
        int divideSeven = (number % 7);

        Console.WriteLine((divideFive == 0 && divideSeven == 0) ? "The number could be divided by 5 and 7 without reminder!"
            : "he number could NOT be divided by 5 and 7 without reminder!");
    }
}

