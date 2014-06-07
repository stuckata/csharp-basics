using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestSubsequenceOfEqualNums
{
    static void Main()
    {
        Console.WriteLine("This program find and print the longest subsequence of numbers in a given list of integers:");
        List<int> nums = new List<int>
        { 1, 1, 1, 2, 3, 4, 5, 5, 5, 5, 6, 7, 8, 8, 8, 8, 8, 8  
        };

        PrintStartList(nums);
        List<int> result = FindLongestEqualSubsequence(nums);
        PrintResult(result);
    }

    static void PrintStartList(List<int> nums)
    {
        Console.Write("{ ");
        foreach (int num in nums)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine("}");
    }

    static List<int> FindLongestEqualSubsequence(List<int> nums)
    {
    List<int> result = new List<int>();
    int counter = 1;
    int tempCount = 1;
    int bestNum = 0;

    for (int i = 0; i < nums.Count; i++)
    {
        if (i < nums.Count - 1)
        {
            if (nums[i] == nums[i + 1])
            {
                tempCount++;
            }
            if (tempCount > counter)
            {
                counter = tempCount;
                bestNum = nums[i];
                tempCount = 1;
            }   
        }      
    }

    for (int i = 0; i < counter; i++)
    {
        result.Add(bestNum);
    }

    return result;
    }

    static void PrintResult(List<int> result)
    {
        Console.WriteLine("The longest subsequence of integers is:");
        Console.Write("{ ");
        foreach (int num in result)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine("}");
    }
}
