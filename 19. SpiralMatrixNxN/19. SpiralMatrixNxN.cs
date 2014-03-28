using System;

class SpiralMatrixNxN
{
    static void Main()
    {
        Console.WriteLine("This program reads number N and print a matrix in format NxN.");
        Console.WriteLine("Please enter positive integer number N != 0: ");
        Console.Write("N = ");
        string input = Console.ReadLine();
        int numN = 0;
        bool isValid = int.TryParse(input, out numN);

        while (!isValid || (numN <= 0))
        {
            Console.WriteLine("Invalid number N!");
            Console.WriteLine("Please enter positive integer number N != 0: ");
            Console.Write("N = ");
            input = Console.ReadLine();
            isValid = int.TryParse(input, out numN);
        }

        int[,] matrixN = new int[numN, numN];
        int counter = 1;

        for (int loop = 0; loop <= numN / 2 + 1; loop++)
        {
            for (int col = loop; col < numN - loop; col++)
            {
                matrixN[loop, col] = counter;
                counter++;
            }
            for (int row = loop + 1; row < numN - loop; row++)
            {
                matrixN[row, numN - (loop + 1)] = counter;
                counter++;
            }
            for (int col = numN - (loop + 2); col >= loop; col--)
            {
                matrixN[numN - (loop + 1), col] = counter;
                counter++;
            }
            for (int row = numN - (loop + 2); row >= (loop + 1); row--)
            {
                matrixN[row, loop] = counter;
                counter++;
            }
        }

        for (int row = 0; row < numN; row++) // print result
        {
            for (int col = 0; col < numN; col++)
            {
                Console.Write("{0, 4}", matrixN[row, col]);
            }
            Console.WriteLine();
        }
    }
}

