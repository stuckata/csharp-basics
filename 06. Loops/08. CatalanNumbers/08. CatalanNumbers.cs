using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("This program calculate the n-th Catalan number by given n (1 < n < 100). ");
        Console.WriteLine("Enter integer n: ");
        Console.WriteLine("n = ");

        string input = Console.ReadLine();
        int numN = 0;
        bool isValid = int.TryParse(input, out numN);
        double result = 0;
        double factoriel2N = 1;
        double factorielNPlus1 = 1;
        double factorielN = 1;

        while(!isValid || ((numN <=1) || (numN > 99)))
        {
            Console.WriteLine("Invalid Number!");
            Console.WriteLine("Enter again:");
            Console.WriteLine("n = ");
            input = Console.ReadLine();
            isValid = int.TryParse(input, out numN);
        }

        for (int i = 1; i <= 2 * numN; i++)
        {
            factoriel2N *= i;
            if (i <= numN + 1)
            {
                factorielNPlus1 *= i;
            }
            if (i <= numN)
            {
                factorielN *= i;
            }
        }
        result = factoriel2N / (factorielNPlus1 * factorielN);
        Console.WriteLine(result);
    }
}

