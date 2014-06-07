using System;

class NumbersNotDivisibleByThreeAndSeven
{
    static void Main()
    {
        Console.WriteLine("This program print all the numbers from 1 to n not divisible by 3 and 7 where n is positive integer number.");
        Console.WriteLine("Please, enter positive integer number n: ");
        Console.Write("n = ");

        string input = Console.ReadLine();
        int numN = 0;
        bool isValid = int.TryParse(input, out numN);

        while (!isValid || numN <= 0)
        {
            Console.WriteLine("Invalid Number! Please enter positive integer number: ");
            Console.WriteLine("n = ");
            input = Console.ReadLine();
            isValid = int.TryParse(input, out numN);
        }
        for (int i = 1; i <= numN; i++)         
        {
            int divThree = (i % 3);
            int divSeven = (i % 7);

            if (divThree != 0 && divSeven != 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}
