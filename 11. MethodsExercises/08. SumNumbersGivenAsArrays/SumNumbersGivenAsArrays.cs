using System;

class SumNumbersGivenAsArrays
{
    static void Main()
    {
        int[] array1 = new int[] { 1, 2, 3, 3, 4, 5, 6, 7};
        int[] array2 = new int[] { 9, 8, 7, 6, 5, 4 };

        if (array1.Length == array2.Length)
        {
            SumArrays(array1, array2);
        }
        else if (array1.Length > array2.Length)
        {
            SumArrays(array1, array2);
        }
        else
        {
            SumArrays(array2, array1);
        }
    }

    static void SumArrays(int[] longerArr, int[] shorterArr)
    {
        int length = longerArr.Length;
        int[] sum = new int[longerArr.Length + 1];
        int reminder = 0;

        for (int i = 0; i < length; i++)
        {
            if (i < shorterArr.Length)
            {
                sum[(sum.Length - 1) - i] = (longerArr[i] + shorterArr[i]);
            }
            else
            {
                sum[(sum.Length - 1) - i] = longerArr[i];
            }

            if (reminder == 1)
            {
                sum[(sum.Length - 1) - i] += 1;
                reminder = 0;
            }

            if ((sum[(sum.Length - 1) - i] >= 10) && (i != length - 1))
            {
                reminder = 1;
                sum[(sum.Length - 1) - i] = (sum[(sum.Length - 1) - i] % 10);
            }

            if ((i == length - 1) && (sum[(sum.Length - 1) - i] >= 10))
            {
                sum[(sum.Length) - i] = (sum[(sum.Length - 1) - i] / 10);
                sum[(sum.Length - 1) - i] = (sum[(sum.Length - 1) - i] % 10);
            }
        }

        if (sum[0] == 0)
        {
            for (int i = 1; i < sum.Length; i++)
            {
                Console.Write(sum[i]);
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i]);
            }
            Console.WriteLine();
        }
    }
}

