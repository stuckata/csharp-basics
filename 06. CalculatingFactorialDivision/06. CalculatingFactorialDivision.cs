using System;

class CalculatingFactorialDivision
{
    static void Main()
    {
        Console.WriteLine("This program calculate n! / k! for integers n and k (1 < k < n < 100).");
        Console.WriteLine("Please, enter n and k: ");

        Console.Write("n = ");
        string inputN = Console.ReadLine();
        Console.Write("k = ");
        string inputK = Console.ReadLine();

        int numN = 0;
        int numK = 0;
        int factorialN = 1;
        int factorialK = 1;
        double calculation = 0;
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
        }
        calculation = factorialN / factorialK;
        Console.WriteLine("n! / k! = {0 : 0.##}", calculation);
    }
}

