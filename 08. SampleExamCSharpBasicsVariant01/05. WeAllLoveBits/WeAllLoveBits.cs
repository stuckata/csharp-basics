using System;
using System.Linq;

class WeAllLoveBits
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int[] bitNums = new int[numN];
        int[] resultNums = new int[numN];

        for (int i = 0; i < bitNums.Length; i++)
        {
            bitNums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < bitNums.Length; i++)
        {
            resultNums[i] = ConvertToMitkosAlgorith(bitNums[i]);
        }

        foreach (int element in resultNums)
        {
            Console.WriteLine(element);
        }
    }

    static int ConvertToMitkosAlgorith(int num)
    {
        int invBitNum = InvertNumberBitwise(num);
        int revBitNum = ReverseNumberBitwise(num);
        int transfNum = (num ^ invBitNum) & revBitNum; //  Pnew = (P ^ P̃) & P̈.

        return transfNum;
    }

    static int InvertNumberBitwise(int num)
    {
        int invBitNum = ~num;
        return invBitNum;
    }

    static int ReverseNumberBitwise(int num)
    {
        int[] bits = ConvertToBinaryNum(num);
        int temp = 0;
        string numBin = "";

        for (int i = 0; i < bits.Length / 2; i++)
        {
            temp = bits[i];
            bits[i] = bits[bits.Length - 1 - i];
            bits[bits.Length - 1 - i] = temp;
        }

        foreach (int element in bits)
        {
            numBin += element;
        }
        int numDec = ConvertToDecimalNum(numBin);
        return numDec;
    }

    static int[] ConvertToBinaryNum(int num)
    {
        string numDec = Convert.ToString(num, 2);
        int[] bits = numDec.Select(c => int.Parse(c.ToString())).ToArray();
        return bits;
    }

    static int ConvertToDecimalNum(string numBinStr)
    {
        int numDec = Convert.ToInt32(numBinStr, 2);
        return numDec;
    }
}

