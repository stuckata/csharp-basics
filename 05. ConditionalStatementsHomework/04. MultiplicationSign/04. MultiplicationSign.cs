using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter 3 real numbers and the program will return the sign of their multiplication: ");

        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());

        if ((numA == 0 || numB == 0) || numC == 0)
        {
            Console.WriteLine("0");
            return;
        }
        if ((numA > 0 && numB > 0) && (numC > 0)) 
        {
            Console.WriteLine("+");
            return;
        }
        if ((numA < 0 && numB < 0) && numC < 0)
        {
            Console.WriteLine("-");
            return;
        }
        if ((((numA < 0 && numB < 0) && numC > 0) || ((numA < 0 && numB > 0) && numC < 0)) || ((numA > 0 && numB < 0) && numC < 0))
        {
            Console.WriteLine("+");
            return;
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}

