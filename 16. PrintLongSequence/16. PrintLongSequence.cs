using System;

class PrintLongSequence
{
    static void Main()
    {
        int firstNumber = 2;
        int multiplier = 1;

        for (int i = firstNumber; i < firstNumber + 1000; i++)
        {
            Console.Write(i * multiplier);
            if (i != firstNumber + 1000 - 1)
            {
                Console.Write(", ");
            }
            multiplier = multiplier * (-1);
        }

    }
}
