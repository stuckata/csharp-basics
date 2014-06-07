using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountNumberDuplicateInArray
{
    static void Main()
    {
        Console.WriteLine("This program find how many times a number is repeating in a array.");
        int[] arrayNums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 1, 2, 1 };

        PrintArrayNumbers(arrayNums);
        int num = EnterNumber();
        int countNum = FindNumInArray(arrayNums, num);
        PrintResult(num, countNum);
    }

    private static void PrintResult(int num, int count)
    {
        Console.WriteLine("The number {0} repeat {1} times in the array", num, count);
    }

    static int EnterNumber()
    {
        Console.WriteLine("Enter number to find how many times could be found in the array.");
        Console.Write("number = ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static void PrintArrayNumbers(int[] arrayNums)
    {
        Console.Write("The numbers in the array are: ");
        Console.Write("[ ");

        for (int i = 0; i < arrayNums.Length; i++)
        {
            Console.Write("{0}", arrayNums[i]);
            if (i < arrayNums.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write(" ]");
        Console.WriteLine();
    }

    static int FindNumInArray(int[] arrayNums, int num)
    {
        int counter = 0;

        for (int i = 0; i < arrayNums.Length; i++)
        {
            if (num == arrayNums[i])
            {
                counter++;
            }
        }
        return counter;
    }
}

