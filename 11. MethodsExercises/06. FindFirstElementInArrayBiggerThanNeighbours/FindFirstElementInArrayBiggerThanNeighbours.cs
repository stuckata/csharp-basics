using System;

class FindFirstElementInArrayBiggerThanNeighbours
{
    static void Main()
    {
        int[] arrayNums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 200, 200 };
        FindFirstElementBiggerThanNeighbours(arrayNums);
    }

    static void FindFirstElementBiggerThanNeighbours(int[] array)
    {
        int targetIndex = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (i != 0 && i != array.Length - 1)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    targetIndex = i;
                    break;
                }
            }
            else if (i == 0)
            {
                if (array[i] > array[i + 1])
                {
                    targetIndex = i;
                    break;
                }
            }
            else if (i == array.Length - 1)
            {
                if (array[i] > array[i - 1])
                {
                    targetIndex = i;
                    break;
                }
            }
        }
        if (targetIndex >= 0)
        {
            Console.WriteLine("array[{0}] = {1}", targetIndex, array[targetIndex]);
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}

