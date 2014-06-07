using System;

class PieceOfCake
{
    static void Main()
    {
        decimal numA = decimal.Parse(Console.ReadLine());
        decimal numB = decimal.Parse(Console.ReadLine());
        decimal numC = decimal.Parse(Console.ReadLine());
        decimal numD = decimal.Parse(Console.ReadLine());

        decimal generalDenominator = numB * numD;
        decimal nominatorA = numA * numD;
        decimal nominatorC = numC * numB;

        decimal sumNomerators = nominatorA + nominatorC;

        if (sumNomerators / generalDenominator >= 1)
        {
            Console.WriteLine((int)(sumNomerators / generalDenominator));
        }
        else
        {
            Console.WriteLine("{0:0.0000000000000000000000}", sumNomerators / generalDenominator);
        }

        Console.WriteLine("{0}/{1}", sumNomerators, generalDenominator);
    }
}