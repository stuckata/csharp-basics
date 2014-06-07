using System;
using System.Collections.Generic;

class MethodPrimesInGivenRange
{
    static void Main()
    {
        Console.WriteLine("This program calculates and print all prime numbers in given range.");

        PrintInputConditions();
        long numStart = ValidateInput();
        long numEnd = ValidateInput();
        Console.WriteLine("Prime numbers in range {0} - {1} are: ", numStart, numEnd);
        List<long> listOfPrimes = FindPrimesInRange(numStart, numEnd);      
        PrintResultList(listOfPrimes);       
    }

    static void PrintInputConditions()
    {
        Console.WriteLine();
        Console.WriteLine("Enter two positive integer numbers which will define a range: ");
    }

    static void PrintInvalidNumber()
    {
        Console.WriteLine("Invalid number");
    }

    static long ValidateInput()
    {
        long num = 0;
        string input = Console.ReadLine();
        bool isValid = long.TryParse(input, out num);

        while (!isValid || !(num >= 0))
        {
            PrintInvalidNumber();
            PrintInputConditions();
            input = Console.ReadLine();
            isValid = long.TryParse(input, out num);
        }

        return num;
    }

    static List<long> FindPrimesInRange(long numStart, long numEnd)
    {
        List<long> listOfPrimes = new List<long>();

        if (numStart == 0 || numStart == 1)
        {
            numStart = 2;
        }

        for (long range = numStart; range <= numEnd; range++)
        {
            bool isPrime = true;

            for (long num = 2; num <= Math.Sqrt(range); num++)
            {
                if ((range % num) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                listOfPrimes.Add(range);
            }
        }
        return listOfPrimes;
    }

    static void PrintResultList(List<long> listOfPrime)
    {
        if (listOfPrime.Count == 0)
        {
            Console.WriteLine("(empty list)");
            return;
        }
        bool printComma = false;

        foreach (long prime in listOfPrime)
        {
            if (!printComma)
            {
                Console.Write(prime);
                printComma = true;
            }
            else
            {
                Console.Write(", " + prime);
            }           
        }
        Console.WriteLine();
    }
}

