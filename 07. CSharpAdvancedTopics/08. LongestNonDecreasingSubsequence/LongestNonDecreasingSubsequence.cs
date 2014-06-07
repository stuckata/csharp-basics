using System;
using System.Collections.Generic;
using System.Linq;

class LongestNonDecreasingSubsequence
{
    static void Main()
    {
        Console.WriteLine("This program reads a sequence of integers and finds in it the longest non-decreasing subsequence. ");
        Console.WriteLine();

        int[] numArr = EnterNumbers();
        FindNonDecreasingSubsequence(numArr);
    }

    static void PrintInputConditions()
    {
        Console.WriteLine("Please, enter a sequence of integers on a single line divided by space: ");
        Console.Write("Input: ");
    }

    static int[] EnterNumbers()
    {
        PrintInputConditions();
        string[] inputArr = Console.ReadLine().Split(' ');
        int[] numArr = new int[inputArr.Length];
        int num = 0;
        bool isValid = false;

        for (int i = 0; i < inputArr.Length; i++)
        {
            isValid = int.TryParse(inputArr[i], out num);
            numArr[i] = num;
        }

        if (!isValid)
        {
            Console.WriteLine("Inavlid Input!");
            Console.WriteLine("Please, restart the program!");
        }
        return numArr;
    }

    static void FindNonDecreasingSubsequence(int[] numArr)
    {
        List<List<int>> listOfNonDecrSubs = new List<List<int>>();

        for (int index = 1; index <= numArr.Length; index++)
        {
            listOfNonDecrSubs = AddNumber(listOfNonDecrSubs, numArr[index - 1]);
        }

        List<int> longestSubSequence = FindLongestList(listOfNonDecrSubs);

        foreach (int num in longestSubSequence)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static List<int> FindLongestList(List<List<int>> container)
    {
        List<int> longestList = new List<int>();
        int longestLength = 0;

        foreach (List<int> l in container)
        {
            if (longestLength < l.Count)
            {
                longestLength = l.Count;
                longestList = l;
            }
        }
        return longestList;
    }

    static List<List<int>> AddNumber(List<List<int>> container, int num)
    {
        List<int> next = new List<int>();
        bool isAdded = false;
        foreach (List<int> list in container)
        {
            isAdded = false;
            int lastNum = list.ElementAt(list.Count - 1);

            if (num >= lastNum)
            {
                list.Add(num);
                isAdded = true;
            }
            else if (num < lastNum && list.Count > 1)
            {
                int preLastNum = list.ElementAt(list.Count - 2);
                if (preLastNum < num)
                {
                    list.RemoveAt(list.Count - 1);
                    list.Add(num);
                    isAdded = true;
                }
            }
        }
        if (!isAdded)
        {
            next.Add(num);
            container.Add(next);
        }
        return container;
    }
}

