using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        double sum = 0;
        Console.WriteLine("Please, Enter 5 numbers, separated by a space: ");
        string nums = Console.ReadLine();

        foreach (int element in nums)
        {
            //double temp = 0;
            //try
            //{
            //    temp = Convert.ToDouble(element);
            //    sum += temp;
            //}
            //catch (FormatException)
            //{
            //    temp = 0;
            //}
            //catch (OverflowException)
            //{
            //    temp = 0;
            //}
        }
        Console.WriteLine(sum);
    }
}
