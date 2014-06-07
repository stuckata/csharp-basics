using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UsingStackPrintReversedNumbers
{
    static void Main()
    {
        Console.WriteLine("This program could print inputed integer numbers in reversed order.");
        Stack<int> numbers = InputNumbers();
        PrintResult(numbers);
    }

    static void PrintResult(Stack<int> numbers)
    {
        Console.Write("The result is: ");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void PrintInputConditions()
    {
        Console.WriteLine("Please, enter the number of integers which will be printed: ");
        Console.Write("n = ");
    }

    static Stack<int> InputNumbers()
    {
        PrintInputConditions();
        Stack<int> numbers = new Stack<int>();
        int numN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} integer numbers", numN);

        for (int i = 0; i < numN; i++)
        {
            int num = int.Parse(Console.ReadLine());
            numbers.Push(num);
        }

        return numbers;
    }
}

