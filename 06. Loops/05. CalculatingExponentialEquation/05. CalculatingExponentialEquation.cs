using System;

class CalculatingExponentialEquation
{
    static void Main()
    {
        Console.WriteLine("This program calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn");
        Console.WriteLine("Please enter the two integers n and x: ");

        Console.Write("n = ");
        string inputN = Console.ReadLine();
        Console.Write("x = ");
        string inputX = Console.ReadLine();

        int numN = 0;
        int numX = 0;
        double sum = 0;
        double memberN = 1;
        int factorialN = 1;
        double temp = 0;
        bool isValidN = int.TryParse(inputN, out numN);
        bool isValidX = int.TryParse(inputX, out numX);

        while (!isValidN || !isValidX)
        {
            Console.WriteLine("Invalid integer number!");
            Console.WriteLine("Enter again two integers n and x: ");
            Console.Write("n = ");
            inputN = Console.ReadLine();
            Console.Write("x = ");
            inputX = Console.ReadLine();
            isValidN = int.TryParse(inputN, out numN);
            isValidX = int.TryParse(inputX, out numX);
        }

        for (int i = 1; i <= numN; i++)
        {
            factorialN = factorialN * i;
            memberN = (factorialN/ Math.Pow(numX, i));
            temp += memberN;
        }
        sum = 1 + temp;
        Console.WriteLine("S = {0 : 0.00000}", sum);
    }
}

