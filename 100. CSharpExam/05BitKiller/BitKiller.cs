using System;

class BitKiller
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] numbers = new int[numN];
        int calculateStep = 0;
        int maxLengthOfNum = numN * 8;
        int stepCount = maxLengthOfNum / step;
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }


        while (calculateStep <= maxLengthOfNum)
        {
            calculateStep = 1 + step * counter;

            counter++;
        }

    }

    static int BitwiseOrWith1(int num)
    {
        num = num | 1;
        return num;
    }

    static int BitwiseAndWith1(int num)
    {
        num = num & 1;
        return num;
    }
}

