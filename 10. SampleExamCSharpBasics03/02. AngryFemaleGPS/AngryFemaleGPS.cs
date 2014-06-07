using System;

class AngryFemaleGPS
{
    static void Main()
    {
        long numN = long.Parse(Console.ReadLine());
        numN = Math.Abs(numN);
        long tempNum = 0;
        long balance = 0;
        long oddSum = 0;
        long evenSum = 0;

        while (numN >= 1)
        {
            tempNum = numN % 10;
            balance = tempNum % 2;

            if (balance == 0)
            {
                evenSum += tempNum;
            }
            else
            {
                oddSum += tempNum;
            }

            numN = (numN / 10);
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("straight {0}", evenSum);
        }
        else if (evenSum > oddSum)
        {
            Console.WriteLine("right {0}", evenSum);
        }
        else
        {
            Console.WriteLine("left {0}", oddSum);
        }
    }
}

