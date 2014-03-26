using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("This program read from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix");
        Console.WriteLine("Enter value for n: ");
        Console.Write("n = ");

        string input = Console.ReadLine();
        int numN = 0;
        bool isValid = int.TryParse(input, out numN);
        int matrixNum = 0;
        int firstDigit = 1;

        while (!isValid || !(numN >= 1 && numN <= 20))
        {
            Console.WriteLine("Invalid Number");
            Console.WriteLine("Enter positive integer number n (1 ≤ n ≤ 20): ");
            Console.Write("n = ");
            input = Console.ReadLine();
            isValid = int.TryParse(input, out numN);
        }

        for (int col = 0; col < numN; col++)
        {
            matrixNum = firstDigit;
            for (int row = 0; row < numN; row++)
            {
                Console.Write("{0, 2} ", matrixNum);
                matrixNum ++;
            }
            Console.WriteLine();
            firstDigit++;
        }
    }
}

