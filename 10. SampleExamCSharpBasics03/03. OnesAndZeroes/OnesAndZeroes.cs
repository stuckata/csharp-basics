using System;

class OnesAndZeroes
{
    static void Main()
    {
        long numN = long.Parse(Console.ReadLine());
        int[] numNBinary = new int[16];

        for (int i = numNBinary.Length - 1; i >= 0; i--)
        {
            if ((numN & 1) == 1)
            {
                numNBinary[i] = 1;
            }
            else
            {
                numNBinary[i] = 0;
            }
            numN = numN >> 1;
        }

        for (int i = 0; i < numNBinary.Length; i++)
        {
            if (numNBinary[i] == 0 && i != (numNBinary.Length - 1))
            {
                PrintFirstAndLastRowZero();
            }
            else if (numNBinary[i] == 1 && i != (numNBinary.Length - 1))
            {
                PrintFirstThirdAndFourthRowOne();
            }
            else if (numNBinary[i] == 0 && i == (numNBinary.Length - 1))
            {
                PrintFirstAndLastRowLastDigitZero();
            }
            else
            {
                PrintFirstThirdAndFourthRowLastDigitOne();
            }
        }
        Console.WriteLine();

        for (int i = 0; i < numNBinary.Length; i++)
        {
            if (numNBinary[i] == 0 && i != (numNBinary.Length - 1))
            {
                PrintSecondThirdAndFourthRowZero();
            }
            else if (numNBinary[i] == 1 && i != (numNBinary.Length - 1))
            {
                PrintSecondRowOne();
            }
            else if (numNBinary[i] == 0 && i == (numNBinary.Length - 1))
            {
                PrintSecondThirdAndFourthRowLastDigitZero();
            }
            else
            {
                PrintSecondRowLastDigitOne();
            }
        }
        Console.WriteLine();

        for (int i = 0; i < numNBinary.Length; i++)
        {
            if (numNBinary[i] == 0 && i != (numNBinary.Length - 1))
            {
                PrintSecondThirdAndFourthRowZero();
            }
            else if (numNBinary[i] == 1 && i != (numNBinary.Length - 1))
            {
                PrintFirstThirdAndFourthRowOne();
            }
            else if (numNBinary[i] == 0 && i == (numNBinary.Length - 1))
            {
                PrintSecondThirdAndFourthRowLastDigitZero();
            }
            else
            {
                PrintFirstThirdAndFourthRowLastDigitOne();
            }
        }
        Console.WriteLine();

        for (int i = 0; i < numNBinary.Length; i++)
        {
            if (numNBinary[i] == 0 && i != (numNBinary.Length - 1))
            {
                PrintSecondThirdAndFourthRowZero();
            }
            else if (numNBinary[i] == 1 && i != (numNBinary.Length - 1))
            {
                PrintFirstThirdAndFourthRowOne();
            }
            else if (numNBinary[i] == 0 && i == (numNBinary.Length - 1))
            {
                PrintSecondThirdAndFourthRowLastDigitZero();
            }
            else
            {
                PrintFirstThirdAndFourthRowLastDigitOne();
            }
        }
        Console.WriteLine();

        for (int i = 0; i < numNBinary.Length; i++)
        {
            if (numNBinary[i] == 0 && i != (numNBinary.Length - 1))
            {
                PrintFirstAndLastRowZero();
            }
            else if (numNBinary[i] == 1 && i != (numNBinary.Length - 1))
            {
                PrintFirstAndLastRowZero();
            }
            else if (numNBinary[i] == 0 && i == (numNBinary.Length - 1))
            {
                PrintFirstAndLastRowLastDigitZero();
            }
            else
            {
                PrintFirstAndLastRowLastDigitZero();
            }
        }

    } 
    static void PrintFirstAndLastRowZero()
    {
        Console.Write('#');
        Console.Write('#');
        Console.Write('#');
        Console.Write('.');
    }

    static void PrintFirstAndLastRowLastDigitZero()
    {
        Console.Write('#');
        Console.Write('#');
        Console.Write('#');
    }

    static void PrintFirstThirdAndFourthRowOne()
    {
        Console.Write('.');
        Console.Write('#');
        Console.Write('.');
        Console.Write('.');
    }

    static void PrintFirstThirdAndFourthRowLastDigitOne()
    {
        Console.Write('.');
        Console.Write('#');
        Console.Write('.');
    }

    static void PrintSecondThirdAndFourthRowZero()
    {
        Console.Write('#');
        Console.Write('.');
        Console.Write('#');
        Console.Write('.');
    }

    static void PrintSecondThirdAndFourthRowLastDigitZero()
    {
        Console.Write('#');
        Console.Write('.');
        Console.Write('#');
    }

    static void PrintSecondRowOne()
    {
        Console.Write('#');
        Console.Write('#');
        Console.Write('.');
        Console.Write('.');
    }

    static void PrintSecondRowLastDigitOne()
    {
        Console.Write('#');
        Console.Write('#');
        Console.Write('.');
    }

}

