using System;
using System.Numerics;

class SubsetSums
{
    static void Main()
    {
        BigInteger sumS = BigInteger.Parse(Console.ReadLine());
        int numN = int.Parse(Console.ReadLine());
        BigInteger[] num = new BigInteger[numN];
        int counter = 0;

        for (int i = 0; i < num.Length; i++)
        {
            num[i] = BigInteger.Parse(Console.ReadLine());
            if (num[i] == sumS)
            {
                counter++;
            }
        }

        Array.Sort(num);

        BigInteger tempSum = num[0];

        for (int i1 = 0; i1 < num.Length - 1; i1++)
        {
            tempSum += num[i1 + 1];

            if (tempSum == sumS)
            {
                counter++;
            }

            for (int i2 = (i1 + 1); i2 < num.Length; i2++)
            {
                if (num[i1] + num[i2] == sumS)
                {
                    counter++;
                }
                if (i2 < num.Length - 1)
                {
                    if (tempSum + num[i2 + 1] == sumS)
                    {
                        counter++;
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}

