using System;
using System.Numerics;
class Tribonacci
{
    static void Main()
    {
        BigInteger firstEle = BigInteger.Parse(Console.ReadLine());
        BigInteger secondEle = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdEle = BigInteger.Parse(Console.ReadLine());
        int numN = int.Parse(Console.ReadLine());
        BigInteger tempEle = 0;
        int counter = 3;

        if (numN == 1)
        {
            Console.WriteLine(firstEle);
        }
        else if (numN == 2)
        {
            Console.WriteLine(secondEle);
        }
        else if (numN == 3)
        {
            Console.WriteLine(thirdEle);
        }
        else
        {
            while (counter < numN)
            {
                tempEle = thirdEle;
                thirdEle = firstEle + secondEle + thirdEle;
                firstEle = secondEle;
                secondEle = tempEle;
                counter++;
            }
            Console.WriteLine(thirdEle);
        }
    }
}
