using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class CalculatingNFactorialUpToOneHundred
{
    static void Main()
    {
        Console.WriteLine("This Program calculates the n! for given number n up to 100.");
        PrintInputConditions();
        int num = int.Parse(Console.ReadLine());
        BigInteger result = CalculateNFactorial(num);
        PrintResult(result, num);
    }

    static void PrintResult(BigInteger result, int num)
    {
        Console.WriteLine("{0}! = {1}", num, result);
    }

    static void PrintInputConditions()
    {
        Console.WriteLine("Please enter number n:");
        Console.Write("n = ");
    }

    static BigInteger CalculateNFactorial(int num)
    {
        BigInteger result = 1;

        for (int i = num; i >= 1; i--)
        {
            result *= i;
        }

        return result;
    }
}

