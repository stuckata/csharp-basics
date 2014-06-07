using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemoveAllNonPositiveNumbers
{
    static void Main()
    {
        Console.WriteLine("This program removes all non positive numbers from a given list.");
        List<int> numbers = new List<int> { 19, -10, 12, -6, -3, 34, -2, 5 };
        PrintNumbersList(numbers);
        List<int> result = RemoveNonPositiveNumbers(numbers);
        PrintResult(result);
    }

    static void PrintResult(List<int> result)
    {
        Console.WriteLine("The list without negative numbers is as follow:");
        Console.Write("{ ");
        foreach (int num in result)
        {          
            Console.Write("{0} ", num);          
        }
        Console.WriteLine("}");
    }

    static void PrintNumbersList(List<int> numbers)
    {
        Console.Write("{ ");
        foreach (int num in numbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine("}");
    }

    static List<int> RemoveNonPositiveNumbers(List<int> numbers)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] >= 0)
            {
                result.Add(numbers[i]);
            }
        }

        return result;
    }
}

