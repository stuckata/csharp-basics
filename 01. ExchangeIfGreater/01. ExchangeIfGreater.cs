using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter two variables a and b. The program will exchange their values if the first variable is greater a > b.");
        Console.WriteLine("Enter the first one a: ");
        double numA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second one b:");
        double numB = double.Parse(Console.ReadLine());
        Console.WriteLine("a = {0}; b = {1}", numA, numB);
        double temp = 0;

        if (numA > numB)
        {
            temp = numA;
            numA = numB;
            numB = temp;
            Console.WriteLine("a > b and the values are: a = {0}; b = {1}", numA, numB);
        }
        else
        {
            Console.WriteLine("a <= b and the values are the same: a = {0}; b = {1}", numA, numB);
        }
    }
}

