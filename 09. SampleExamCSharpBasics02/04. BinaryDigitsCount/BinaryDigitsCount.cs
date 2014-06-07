using System;
using System.Numerics;

class BinaryDigitsCount
{
    static void Main()
    {
        int numB = int.Parse(Console.ReadLine());
        int numN = int.Parse(Console.ReadLine());
        BigInteger[] numbers = new BigInteger[numN];
        int[] resultZero = new int[numN];
        int[] resultOne = new int[numN];

        for (int i = 0; i < numN; i++)
        {
            numbers[i] = BigInteger.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            int acc0 = 0;
            int acc1 = 0;
 
            while (numbers[i] > 0)
            {
                if ((numbers[i] & 1) == 0)
                {
                    acc0++;                  
                }
                else
                {
                    acc1++; 
                }
                numbers[i] = (numbers[i] >> 1);
            }
            resultZero[i] = acc0;
            resultOne[i] = acc1;
        }

        if (numB == 0)
        {
            foreach (int num in resultZero)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            foreach (int num in resultOne)
            {
                Console.WriteLine(num);
            }
        }
    }
}

