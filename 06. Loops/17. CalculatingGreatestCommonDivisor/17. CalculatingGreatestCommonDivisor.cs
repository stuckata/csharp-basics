using System;

class CalculatingGreatestCommonDivisor
{

    static int getGCD(int numA, int numB)
    {

        while (numA != numB)
        {
            if (numA > numB)
            {
                numA = (numA - numB);
            }
            else
            {
                numB = (numB - numA);
            }
        }
       return numA;
    }
    static void Main()
    {
        
        Console.WriteLine("This program calculates the greatest common divisor of two integer numbers.");
        Console.WriteLine("Please, enter two integer numbers a and b: ");
        Console.Write("a = ");
        string inputA = Console.ReadLine();
        Console.Write("b = ");
        string inputB = Console.ReadLine();
        int numA = 0;
        int numB = 0;
        int result = 0;
        bool isValidA = int.TryParse(inputA, out numA);
        bool isValidB = int.TryParse(inputB, out numB);

        while (!isValidA || !isValidB)
        {
            Console.WriteLine("Invalid Numbers! Please, enter two integer numbers a and b: ");
            Console.Write("a = ");
            inputA = Console.ReadLine();
            Console.Write("b = ");
            inputB = Console.ReadLine();
            isValidA = int.TryParse(inputA, out numA);
            isValidB = int.TryParse(inputB, out numB);
        }

        if (numA == 0)
        {
            if (numB >= 0)
            {
                Console.WriteLine("GCD = {0}", numB);
                return;
            }
            else
            {
                result = -numB;
                Console.WriteLine("GCD = {0}", result);
                return;
            }
        }

        if (numB == 0)
        {
            if (numA >= 0)
            {
                Console.WriteLine("GCD = {0}", numA);
                return;
            }
            else
            {
                result = -numA;
                Console.WriteLine("GCD = {0}", result);
                return;
            }
        }       

        if (numA < 0)
        {
            numA = -numA;
        }

        if (numB < 0)
        {
            numB = -numB;
        }

        result = getGCD(numA, numB);
        Console.WriteLine("GCD = {0}", result);
    }
}

