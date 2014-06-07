using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        double sum = 0;
        Console.WriteLine("Please, Enter 5 numbers, separated by a space: ");
        string[] nums = Console.ReadLine().Split(' ');
        double temp = 0;

        foreach (string element in nums)
        {
                temp = Convert.ToDouble(element);
                sum += temp;
        }
        Console.Write(sum);
        Console.WriteLine();
    }
}
