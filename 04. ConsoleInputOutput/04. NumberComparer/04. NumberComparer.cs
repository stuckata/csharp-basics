using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Please, enter the first number for comparing:");
        double numA = double.Parse(Console.ReadLine());
        Console.WriteLine("Now enter the second number:");
        double numB = double.Parse(Console.ReadLine());
        Console.WriteLine("The numbers are A = {0}, B = {1}.", numA, numB);
        Console.Write("The greater one is: ");
        Console.WriteLine(numA > numB ? numA : numB);
    }
}