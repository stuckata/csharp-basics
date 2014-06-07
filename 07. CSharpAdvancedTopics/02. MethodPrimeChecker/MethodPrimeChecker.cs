using System;

class MethodPrimeChecker
{
    static void Main()
    {
        Console.WriteLine("This program check if an integer n is a prime or not and returns true or false as a result.");

        long numN = ValidateInput();
        bool isPrime = IsPrime(numN);

        Console.WriteLine("Prime number {0}? {1}", numN, isPrime);

    }

    static void PrintInputConditions()
    {
        Console.WriteLine("Enter positive integer n:");
        Console.Write("n = ");
    }

    static long ValidateInput()
    {
        long numN = 0;
        PrintInputConditions();
        string input = Console.ReadLine();
        bool isValid = long.TryParse(input, out numN);

        while (!isValid || !(numN >= 0))
        {
            Console.WriteLine("Invalid number!");
            PrintInputConditions();
            input = Console.ReadLine();
            isValid = long.TryParse(input, out numN);
        }
        return numN;
    }

    static bool IsPrime(long numN)
    {
        bool isPrime = true;

        if (numN == 1 || numN == 0)
        {
            isPrime = false;
            return isPrime;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(numN); i++)
            {
                if ((numN % i) == 0)
                {
                    isPrime = false;
                    break;
                }
            }            
        }
        return isPrime;
    }
}

