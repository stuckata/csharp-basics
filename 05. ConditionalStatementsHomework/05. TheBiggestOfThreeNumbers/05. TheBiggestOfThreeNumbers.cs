using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers and the program will return the biggest one: ");

        Console.Write("a = ");
        double numA = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double numB = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double numC = double.Parse(Console.ReadLine());

        Console.Write("The biggest number is :");
       
        if (numA >= numB && numA >= numC)
        {
            Console.WriteLine(numA);
            return;
        }
        if (numB >= numA && numB >= numC)
        {
            Console.WriteLine(numB);
            return;
        }
        else
        {
            Console.WriteLine(numC);
        }
    }
}

