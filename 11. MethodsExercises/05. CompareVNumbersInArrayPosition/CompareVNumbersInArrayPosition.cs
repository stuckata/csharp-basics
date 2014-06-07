using System;

class CompareVNumbersInArrayPosition
{
    static void Main()
    {
        Console.WriteLine("This program compare number at given index with its neighbours.");

        int[] arrayNums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 1, 2, 1 };

        int index = InputIndex(arrayNums.Length);
        CompareWithNeighbourPositions(index, arrayNums);
    }

    static int InputIndex(int range)
    {
        Console.WriteLine("Please enter the index in array.");
        Console.WriteLine("The possible positions are in the range 0 - {0}:s", range);
        Console.Write("index = ");
        int position = int.Parse(Console.ReadLine());
        return position;
    }

    static void CompareWithNeighbourPositions(int index, int[] array)
    {
        if (index != 0 && index != array.Length - 1)
        {
            if (array[index] >= array[index - 1] && array[index] >= array[index + 1])
            {
                Console.WriteLine("The element at position {0} is {1} and {1} >= {2}, {1} >= {3}", index, array[index], array[index - 1], array[index + 1]);
            }
            else if (array[index] < array[index - 1] && array[index] < array[index + 1])
            {
                Console.WriteLine("The element at position {0} is {1} and {1} < {2}, {1} < {3}", index, array[index], array[index - 1], array[index + 1]);
            }
            else if (array[index] < array[index - 1] && array[index] >= array[index + 1])
            {
                Console.WriteLine("The element at position {0} is {1} and {1} < {2}, {1} >= {3}", index, array[index], array[index - 1], array[index + 1]);
            }
            else if (array[index] >= array[index - 1] && array[index] < array[index + 1])
            {
                Console.WriteLine("The element at position {0} is {1} and {1} >= {2}, {1} < {3}", index, array[index], array[index - 1], array[index + 1]);
            }
        }
        else if (index == 0)
        {
            if (array[index] >= array[index + 1])
            {
                Console.WriteLine("The element at position {0} is {1} and {1} >= {2}", index, array[index], array[index + 1]);
            }
            else
            {
                Console.WriteLine("The element at position {0} is {1} and {1} < {2}", index, array[index], array[index + 1]);
            }
        }
        else if (index == array.Length - 1)
        {
             if (array[index] >= array[index - 1])
            {
                Console.WriteLine("The element at position {0} is {1} and {1} >= {2}", index, array[index], array[index - 1]);
            }
            else
            {
                Console.WriteLine("The element at position {0} is {1} and {1} < {2}", index, array[index], array[index - 1]);
            }
        }
    }
}

