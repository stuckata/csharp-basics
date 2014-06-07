using System;

class PrintSequenceOfNumbers
{
    static void Main()
    {
        int firstNumber = 2;
        int multiplier = 1;

        for (int i = firstNumber; i < firstNumber + 10; i++)
        {
            Console.WriteLine(i * multiplier);
            multiplier = multiplier * (-1);
        }

    }
}
