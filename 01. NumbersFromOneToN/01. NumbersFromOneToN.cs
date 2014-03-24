using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("This program print all the numbers from 1 to n (positive integer number entered from user.)");
        Console.WriteLine("Please enter positive integer number n: ");
        Console.Write("n = ");

        string input = Console.ReadLine();
        int numN = 0;
        bool isValid = int.TryParse(input, out numN);

        while ((!isValid) || (numN < 0))
        {
            Console.WriteLine("The number is invalid! Please enter new one:");
            Console.Write("n = ");
            input = Console.ReadLine();
            isValid = int.TryParse(input, out numN);
        }
        
        for (int i = 1; i <= numN; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

