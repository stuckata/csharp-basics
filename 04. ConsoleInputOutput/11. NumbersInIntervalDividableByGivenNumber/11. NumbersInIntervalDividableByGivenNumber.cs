using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int givenNum = 5;

        Console.WriteLine("This program reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by {0} is 0.", givenNum);
        Console.WriteLine("Enter two positive integers: ");

        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        int check = 0;
        int p = 0;
        string result = "";

        Console.WriteLine("The numbers dividable by {0} are: ", givenNum);
        for (int i = startNum; i <= endNum; i++)
        {
            check = (i % givenNum);
            if (check == 0)
            {
                p++;
                result = result + i + ", ";
            }
        }
        Console.WriteLine(result.Substring(0, result.Length - 2));
    }
}
