using System;

class FindLongestAreaInArray
{
    static void Main()
    {
        Console.WriteLine("This program find and print the longest area of elements in array of strings.");
        Console.WriteLine();

        int numStr = IsValidStringLength();
        string[] strArray = InputStringArrayElements(numStr);
        FindLongestArea(strArray);
    }

    static void PrintNumberOfStrConditions()
    {
        Console.WriteLine("Please, enter the number of strings to be entered: ");
    }

    static void PrintInvalidNum()
    {
        Console.WriteLine("Invalid number!");
    }

    static int IsValidStringLength()
    {
        PrintNumberOfStrConditions();
        string input = Console.ReadLine();
        int numStr = 0;
        bool isValid = int.TryParse(input, out numStr);
        while (!isValid || !(numStr >= 0))
        {
            PrintInvalidNum();
            PrintNumberOfStrConditions();
            input = Console.ReadLine();
            isValid = int.TryParse(input, out numStr);
        }
        return numStr;
    }

    static string[] InputStringArrayElements(int numStr)
    {
        string[] strArray = new string[numStr];
        string input = "";
        for (int index = 0; index < strArray.Length; index++)
        {
            Console.Write("Enter {0} element: ", (index + 1));
            input = Console.ReadLine();
            strArray[index] = input;
        }
        return strArray;
    }

    static void FindLongestArea(string[] strArray)
    {
        int counter = 1;
        int maxCount = 0;
        int endIndex = 0;

        for (int index = 0; index < strArray.Length - 1; index++)
        {
            if (strArray[index] == strArray[index + 1])
            {
                counter++;

                if (counter > maxCount)
                {
                    maxCount = counter;
                    endIndex = index;
                    counter = 1;
                }
            }
            else
            {
                counter = 1;
            }          
        }
        if (maxCount == 0)
        {
            Console.WriteLine(counter);
            Console.WriteLine(strArray[0]);
        }
        else
        {
            Console.WriteLine(maxCount);

            for (int i = endIndex + 1; i > (endIndex + 1) - maxCount; i--)
            {
                Console.WriteLine(strArray[i]);
            }
        }
    }
}

