using System;
class BitExchangeAdvanced
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        int firstPos = int.Parse(Console.ReadLine());
        int secondPos = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine()); //number of positions that need to be exchanged
        int counter = 0;
        long bitOnFirstPos;
        long bitOnSecondPos;

        if (firstPos + k > 31 || secondPos + k > 31)
        {
            Console.WriteLine("Out of range");
            return;
        }
        else if (k > firstPos && k > secondPos)
        {
            Console.WriteLine("Overlapping");
            return;
        }

        while (counter < k)
        {
            bitOnFirstPos = (num >> firstPos) & 1;
            bitOnSecondPos = (num >> secondPos) & 1;

            if (bitOnFirstPos == 1 && bitOnSecondPos == 0)
            {
                num = (bitOnFirstPos << secondPos) | num;
                num = ~(1 << firstPos) & num;
            }
            else if (bitOnFirstPos == 0 && bitOnSecondPos == 1)
            {
                num = ~(1 << secondPos) & num;
                num = (bitOnSecondPos << firstPos) | num;
            }

            firstPos++;
            secondPos++;
            counter++;
        }

        Console.WriteLine(num);
    }
}