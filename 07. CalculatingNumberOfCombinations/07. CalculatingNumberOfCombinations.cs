using System;

class CalculatingNumberOfCombinations
{
    static void Main()
    {
        Console.WriteLine("This program calculate the number of calculations for k members out of n different elemnts.");
        Console.WriteLine("Please, enter integers n and k which fulfil the condition (1 < k < n < 100): ");

        Console.Write("n = ");
        string inputN = Console.ReadLine();
        Console.Write("k = ");
        string inputK = Console.ReadLine();

        int numN = 0;
        int numK = 0;
        int factorialN = 1;
        int factorialK = 1;
        int factorialNK = 1;
        long result = 0u;
        bool isValidN = int.TryParse(inputN, out numN);
        bool isValidX = int.TryParse(inputK, out numK);

        while ((!isValidN || !isValidX) || (!(1 < numK) || !(numK < numN)) || !(numN < 100))
        {
            Console.WriteLine("Invalid Numbers!");
            Console.Write("n = ");
            inputN = Console.ReadLine();
            Console.Write("k = ");
            inputK = Console.ReadLine();
            isValidN = int.TryParse(inputN, out numN);
            isValidX = int.TryParse(inputK, out numK);
        }

        for (int i = 1; i <= numN; i++)
        {
            factorialN *= i;

            if (i <= numK)
            {
                factorialK *= i;
            }
            if (i <= (numN - numK))
            {
                factorialNK *= i; 
            }
        }
        result = factorialN / (factorialK * factorialNK);
        Console.WriteLine("The number of calculations is: " + result);
    }
}

