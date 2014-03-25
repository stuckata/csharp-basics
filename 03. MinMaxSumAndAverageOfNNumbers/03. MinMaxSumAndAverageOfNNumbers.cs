using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("This program reads from console n integer numbers, and return as result: min, max, sum and avg values.");
        Console.WriteLine("Enter n where n has to be positive integer number bigger than one: ");
        Console.Write("n = ");

        string input = Console.ReadLine();
        int numN = 0;
        bool isValid = int.TryParse(input, out numN);


        while ((!isValid) || (numN < 2)) //check if the input is a valid integer number bigger than 1
        {
            Console.WriteLine("Invalid Number! Enter new number n:");
            Console.Write("n = ");
            input = Console.ReadLine();
            isValid = int.TryParse(input, out numN);
        }

        int[] numArray = new int[numN];
        int min = int.MaxValue;
        int max = int.MinValue;
        double sum = 0;
        double avg = 0;

        for (int i = 0; i < numN; i++)
        {
            Console.WriteLine("Enter {0} number from {1}: ", (i + 1), numN);
            input = Console.ReadLine();
            isValid = int.TryParse(input, out numArray[i]);

            while (!isValid) //check if the input is a valid integer number
            {
                Console.WriteLine("Invalid Number! Enter new integer number: ");
                input = Console.ReadLine();
                isValid = int.TryParse(input, out numArray[i]);
            }
        }

        for (int i = 0; i <= numArray.Length - 1; i++)
        {
            if (min > numArray[i])
            {
                min = numArray[i];
            }
            if (max < numArray[i])
            {
                max = numArray[i];
            }
            sum = (sum + numArray[i]);
        }
        avg = (sum / numN);

        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = {0 : 0.##}", sum);
        Console.WriteLine("avg = {0 : 0.00}", avg);
    }
}

