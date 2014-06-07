using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pairs
{
    static void Main()
    {
        string input = Console.ReadLine();

        int[] numbers = input.Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
        int firstPairSum = 0;
        int nextPairSum = 0;
        bool allPairsEqual = true;
        int temp = 0;
        int maxDiff = int.MinValue;


        for (int i = 0; i < numbers.Length - 3; i++)
        {
            if ((i % 2) == 0)
            {
                firstPairSum = numbers[i] + numbers[i + 1];
                nextPairSum = numbers[i + 2] + numbers[i + 3];
                if (firstPairSum > nextPairSum)
                {
                    temp = Math.Abs(firstPairSum - nextPairSum);
                }
                else
                {
                    temp = Math.Abs(nextPairSum - firstPairSum);
                }

                if (firstPairSum != nextPairSum)
                {
                    allPairsEqual = false;
                }
                if (maxDiff < temp)
                {
                    maxDiff = temp;
                }
            }          
        }

        if (numbers.Length == 2 || allPairsEqual)
        {
            Console.WriteLine("Yes, value={0}", (numbers[0] + numbers[1]));
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}


