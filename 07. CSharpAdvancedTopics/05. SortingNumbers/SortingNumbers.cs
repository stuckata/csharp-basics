using System;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        Console.WriteLine("This program read a sequence of n integers sort and print them.");
        Console.WriteLine();

        PrintInputConditionsN();
        int numN = IsValidInputN();
        int[] array = EnterNumbersToSort(numN);
        SortNumbers(array);
    }

    static void PrintInputConditionsN()
    {
        Console.WriteLine("Enter the number of integers to be sorted: ");
        Console.Write("n = ");
    }

    static void PrintInvalidInput()
    {
        Console.WriteLine("Invalid number!");
    }

    static int IsValidInputN()
    {
        string inputN = Console.ReadLine();
        int numN = 0;
        bool isValid = int.TryParse(inputN, out numN);

        while (!isValid || !(numN >= 0))
        {
            PrintInvalidInput();
            PrintInputConditionsN();
            inputN = Console.ReadLine();
            isValid = int.TryParse(inputN, out numN);
        }
        return numN;
    }

    static int[] EnterNumbersToSort(int numN)
    {
        int[] array = new int[numN];
        for (int index = 0; index < numN; index++)
        {
            PrintInputNumbersConditions(index + 1);
            array[index] = IsValidNumber();
        }
        return array;
    }

    static void PrintInputNumbersConditions(int num)
    {
        Console.Write("Enter {0} number = ", num);
    }

    static int IsValidNumber()
    {
        string input = Console.ReadLine();
        int num = 0;
        bool isValid = int.TryParse(input, out num);

        while (!isValid)
        {
            PrintInvalidInput();
            input = Console.ReadLine();
            isValid = int.TryParse(input, out num);
        }
        return num;
    }

    static void SortNumbers(int[] array)
    {
        int[] sortedCopy = array.OrderBy(i => i).ToArray();

        foreach (int element in sortedCopy)
        {
            Console.WriteLine(element);
        }
    }
}

