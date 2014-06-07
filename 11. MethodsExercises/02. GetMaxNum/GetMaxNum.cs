using System;

class GetMaxNum
{
    static void Main()
    {
        Console.WriteLine("Please enter numbers which will be compared: ");
        Console.Write("First Number = ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Second Number = ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Third Number = ");
        int thirdNum = int.Parse(Console.ReadLine());
        int number = GetMax(GetMax(firstNum, secondNum), thirdNum);
        PrintResult(number);

    }

    static int GetMax(int firstNum, int secondNum)
    {
        if (firstNum >= secondNum)
        {
            return firstNum;
        }
        else
        {
            return secondNum;
        }
    }

    static void PrintResult(int number)
    {
        Console.WriteLine("The biggest number is {0}", number);
    }
}

