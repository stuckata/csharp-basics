using System;
using System.Numerics;

class TrailZeroesInNFactoriel
{
    static void Main()
    {
        Console.WriteLine("This program calculates how many zeroes a factoriel of number n has.");
        Console.WriteLine("Enter positive integer number n: ");
        Console.Write("n = ");
        string input = Console.ReadLine();
        BigInteger numN = 0;
        BigInteger counter = 0; 
        bool isValid = BigInteger.TryParse(input, out numN);       

        while (!isValid || !(numN > 0))
        {
            Console.WriteLine("Ivalid number!");
            Console.WriteLine("Enter positive integer number n: ");
            Console.Write("n = ");
            input = Console.ReadLine();
            isValid = BigInteger.TryParse(input, out numN);
        }

        BigInteger tempNF = numN;

        while (tempNF > 1)
        {
            counter += tempNF / 5;
            tempNF /= 5;
        }
        Console.WriteLine("The number of zeroes in {0}! is {1}", numN, counter);
    }
}

