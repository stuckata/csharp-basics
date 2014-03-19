using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter, how many members of Fibonacci Numbers to be displayed: ");

        int members = int.Parse(Console.ReadLine());
        int firstFibNum = 0;
        int secondFibNum = 1;
        int nextFibNum = 0;

        Console.WriteLine("These are the first {0} members of Fibonacci Numbers: ", members);

        if (members == 1)
        {
            Console.Write(firstFibNum + ".");
            return;
        }       
        if (members == 2)
        {
            Console.Write(firstFibNum + ", " + secondFibNum + ".");
            return;
        }
        Console.Write(firstFibNum + ", " + secondFibNum + ", ");
        for (int i = 2; i < members; i++)
        {
            nextFibNum = firstFibNum + secondFibNum;
            firstFibNum = secondFibNum;
            secondFibNum = nextFibNum;

            if (i < members - 1)
            {
                Console.Write(nextFibNum + ", ");
            }
            else
            {
                Console.Write(nextFibNum + ".");
            }
        }
        Console.WriteLine();
    }
}

