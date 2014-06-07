using System;

class SumOfIntegers
{
    static void Main()
    {
        Console.WriteLine("This program could sum three integers for you. Please enter the first one:");
        double numA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second one:");
        double numB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third integer:");
        double numC = double.Parse(Console.ReadLine());
        double sumABC = numA + numB + numC;
        Console.WriteLine("The sum of the three entered integers {0}, {1} and {2} is: {3}", numA, numB, numC, sumABC);
    }
}