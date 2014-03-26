using System;

class RandomizingTheNumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("This program prints the numbers 1, 2, …, n in random order.");
        Console.WriteLine("Enter integer number n: ");
        Console.Write("n = ");
        string input = Console.ReadLine();
        int numN = 0;
        bool isValidN = int.TryParse(input, out numN);

        while (!isValidN)
        {
            Console.WriteLine("Invalid number n!");
            Console.WriteLine("Enter integer number n: ");
            Console.Write("n = ");
            input = Console.ReadLine();
            isValidN = int.TryParse(input, out numN);
        }

        int[] arrayToN = new int[numN];
        int temp = 0;

        for (int index = 0; index < arrayToN.Length; index++)
        {
            arrayToN[index] = (index + 1);
        }

        Random random = new Random();
        foreach (int index in arrayToN)
        {
            int randomIndex = random.Next(0, (arrayToN.Length - 1));
            temp = arrayToN[index - 1];
            arrayToN[index - 1] = arrayToN[randomIndex];
            arrayToN[randomIndex] = temp;
        }
        foreach (int index in arrayToN)
        {
            Console.Write(arrayToN[index - 1] + " ");
        }
        Console.WriteLine();
    }
}

