using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumAndAverageValueOfNumbers
{
    static void Main()
    {
        Console.WriteLine("This program calculates the sum and avarage value of given positive integer numbers.");
        PrintInputConditions();
        List<int> inputNumbers = InputNumbers();
        int sum = CalculateSum(inputNumbers);
        double averageValue = CalculateAverageValue(inputNumbers, sum);
        PrintResult(sum, averageValue);
    }

    static void PrintResult(int sum, double averageValue)
    {
        Console.WriteLine("The sum of all numbers is S = {0}", sum);
        Console.WriteLine("The average value of all numbers is A = {0}", averageValue);
    }

    static void PrintInputConditions()
    {
        Console.WriteLine(@"Please enter positive integer numbers needed for calculations confirming each one with ""Enter"". When all numbers are entered hit ""Enter"" again.");
    }

    static List<int> InputNumbers()
    {
        List<int> numbersList = new List<int>();
        string inputNum = "";

        do
        {
            inputNum = Console.ReadLine();
            if (inputNum.Length != 0)
            {
                numbersList.Add(int.Parse(inputNum));
            }

        } while (inputNum.Length != 0);

        return numbersList;
    }

    static int CalculateSum (List<int> numbersList)
    {
        int sum = 0;

        for (int i = 0; i < numbersList.Count; i++)
        {
            sum += numbersList[i];
        }

        return sum;
    }

    static double CalculateAverageValue(List<int> numbersList, int sum)
    {
        double averageValue = (sum / numbersList.Count);
        return averageValue;
    }
}

