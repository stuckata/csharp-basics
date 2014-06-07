using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindBiggestNumberInPartOfArray
{
    static void Main()
    {
        Console.WriteLine("This program find biggest element in a part of an array.");
        int[] array = new int[] { 1, 2, 3, 3, 4, 6, 12, 18, 5, 6, 7 };
        Console.WriteLine("The array is {0} elements long.", array.Length);
        Console.WriteLine("Please, enter the index of starting element:");
        Console.Write("Start: ");
        int startInd = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter the index of ending element:");
        Console.Write("End: ");
        int endInd = int.Parse(Console.ReadLine());

        int[] partOfArray = FindPartOfArrayDeclared(array, startInd, endInd);
        int[] sortedPartOfArr = SortArray(partOfArray);
        PrintResult(sortedPartOfArr);
    }

    static int[] FindPartOfArrayDeclared(int[] array, int start, int end)
    {
        int[] partOfArray = new int[end - start];
        int index = 0;

        for (int i = start; i < end; i++)
        {
            partOfArray[index] = array[i];
            index++;
        }
        return partOfArray;
    }

    static int[] SortArray(int[] array)
    {
        Array.Sort(array);
        return array;
    }

    static void PrintResult(int[] array)
    {
        Console.WriteLine("The biggest number in declared range in the array is {0}", array[array.Length - 1]);
    }
}

