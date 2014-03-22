using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers and the program will return the biggest one: ");

        Console.Write("a = ");
        double numA = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double numB = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double numC = double.Parse(Console.ReadLine());

        Console.Write("d = ");
        double numD = double.Parse(Console.ReadLine());

        Console.Write("e = ");
        double numE = double.Parse(Console.ReadLine());

        Console.Write("The biggest number is :");

        if ((numA >= numB && numA>=numC) && (numA >= numD && numA >= numE))
        {
            Console.WriteLine(numA);
        }
        if ((numB >= numA && numB >= numC) && (numB >= numD && numB >= numE))
        {
            Console.WriteLine(numB);
        }
        if ((numC >= numA && numC >= numB) && (numC >= numD && numC >= numE))
        {
            Console.WriteLine(numC);
        }
        if ((numD >= numA && numD >= numB) && (numD >= numC && numD >= numE))
        {
            Console.WriteLine(numD);
        }
        else
        {
            Console.WriteLine(numE);
        }
    }
}

