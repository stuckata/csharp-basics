using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        Console.WriteLine("This program generate a matrix of palindromes with 3 letters with r columnsMtx and c columnsMtx.");

        int rows = EnterNumberOfRows();
        int columns = EnterNumberOfColumns();
        GenerateMatrixOfPalindromes(rows, columns);
    }

    static void PrintInputConditionsR()
    {
        Console.WriteLine("Enter number of columnsMtx: ");
        Console.Write("r = ");
    }

    static void PrintInputConditionsC()
    {
        Console.WriteLine("Enter number of columnsMtx: ");
        Console.Write("c = ");
    }

    static void PrintInvalidInput()
    {
        Console.WriteLine("Invalid Number!");
    }

    static int EnterNumberOfRows()
    {
        PrintInputConditionsR();
        string input = Console.ReadLine();
        int rows = 0;
        bool isValid = int.TryParse(input, out rows);

        while (!isValid || !(rows >= 0))
        {
            PrintInvalidInput();
            PrintInputConditionsR();
            input = Console.ReadLine();
            isValid = int.TryParse(input, out rows);
        }
        return rows;
    }

    static int EnterNumberOfColumns()
    {
        PrintInputConditionsC();
        string input = Console.ReadLine();
        int columns = 0;
        bool isValid = int.TryParse(input, out columns);

        while (!isValid || !(columns >= 0))
        {
            PrintInvalidInput();
            PrintInputConditionsC();
            input = Console.ReadLine();
            isValid = int.TryParse(input, out columns);
        }
        return columns;
    }

    static void GenerateMatrixOfPalindromes(int rowsMtx, int columnsMtx)
    {
        string[,] matrixOfPal = new string[rowsMtx, columnsMtx];
        int ch = 'a';

        for (int row = 0; row < rowsMtx; row++)
        {      
            if (ch == ('z' + 1))
            {
                ch = 'a';
            }
            for (int col = 0; col < columnsMtx; col++)
            {
                matrixOfPal[row, col] = "" + (char)ch + (char)(ch + col) + (char)ch;
            }
            ch++;
        }

        for (int row = 0; row < rowsMtx; row++)
        {
            for (int col = 0; col < columnsMtx; col++)
            {
                Console.Write(matrixOfPal[row, col] + "   ");
            }
            Console.WriteLine();
        }
    }
}

