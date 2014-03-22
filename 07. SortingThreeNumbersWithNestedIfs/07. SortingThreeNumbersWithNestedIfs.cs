using System;

class SortingThreeNumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("This program sort 3 real numbers in descending order.");
        Console.WriteLine("Enter 3 numbers:");

        Console.Write("a = ");
        double numA = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double numB = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double numC = double.Parse(Console.ReadLine());

        Console.Write("result: ");

        if (numA >= numB && numA >= numC)
        {
            Console.Write(numA + " ");
            if (numB >= numC)
            {
                Console.WriteLine(numB + " " + numC);
            }
            else
            {
                Console.WriteLine(numC + " " + numB);
            }
        }
        else if (numB >= numA && numB >= numC)
        {
            Console.Write(numB + " ");
            if (numA >= numC)
            {
                Console.WriteLine(numA + " " + numC);
            }
            else
            {
                Console.WriteLine(numC + " " + numA);
            }
        }
        else
        {
            Console.Write(numC + " ");
            if (numA >= numB)
            {
                Console.WriteLine(numA + " " + numB);
            }
            else
            {
                Console.WriteLine(numB + " " + numA);
            }
        }
    }
}

