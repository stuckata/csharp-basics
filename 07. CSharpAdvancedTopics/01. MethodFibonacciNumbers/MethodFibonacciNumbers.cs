using System;

class MethodFibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("This program calculates n-th Fibonacci number.");

        PrintInputConditions();

        string inputN = Console.ReadLine();
        int numN = 0;
        bool isValid = int.TryParse(inputN, out numN);

        while (!isValid || !(numN >= 0))
        {
            Console.WriteLine("Invalid number!");
            PrintInputConditions();
            inputN = Console.ReadLine();
            isValid = int.TryParse(inputN, out numN);
        }

        CalculateFibonacciNumberN(numN);
    }

    static void PrintInputConditions()
    {
        Console.WriteLine("Enter positive integer number n: ");
        Console.Write("n = ");
    }

    static void CalculateFibonacciNumberN(int numN)
    {
        int result = 0;
        int firstFibNum = 1;
        int secondFibNum = 1;

        if (numN == 0 || numN == 1)
        {
            result = firstFibNum;
        }
        else
        {
            for (int i = 2; i <= numN; i++)
            {
                result = firstFibNum + secondFibNum;
                firstFibNum = secondFibNum;
                secondFibNum = result;
            }
        }
        Console.WriteLine("The {0} member of Fibonacci numbers is {1}", numN, result);
    }
}

