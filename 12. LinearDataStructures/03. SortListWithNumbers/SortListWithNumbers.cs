using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortListWithNumbers
{
    static void Main()
    {
        Console.WriteLine("This program sort in increment order entered integer numbers.");
        PrintInputConditions();
        List<int> numbers = EnterNumbers();
        List<int> sortedNumbers = SortList(numbers);
        PrintResult(sortedNumbers);
    }

    static void PrintResult(List<int> sortedNumbers)
    {
        foreach (int num in sortedNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void PrintInputConditions()
    {
        Console.WriteLine("Please, enter integer numbers to be sorted. When ready hit Enter key one more time.");
    }

    static List<int> EnterNumbers()
    {
        List<int> numbers = new List<int>();
        string input = "";

        do
        {
            input = Console.ReadLine();
            if (input.Length != 0)
            {
                numbers.Add(int.Parse(input));
            }
        } while (input.Length != 0);

        return numbers;
    }

    static List<int> SortList(List<int> numbers)
    {
        numbers.Sort();
        return numbers;
    }
}

