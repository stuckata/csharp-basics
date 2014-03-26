using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("This program allow you to enter 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max].");
        Console.WriteLine("Enter n, min and max: ");
        Console.Write("n = ");
        string inputN = Console.ReadLine();
        Console.Write("min = ");
        string inputMin = Console.ReadLine();
        Console.Write("max = ");
        string inputMax = Console.ReadLine();

        int numN = 0;
        int numMin = 0;
        int numMax = 0;
        bool isValidN = int.TryParse(inputN, out numN);
        bool isValidMin = int.TryParse(inputMin, out numMin);
        bool isValidMax = int.TryParse(inputMax, out numMax);

        while ((!isValidN || !isValidMin) || !isValidMax)
        {
            Console.WriteLine("Invalid Input. Enter new numbers: ");
            Console.Write("n = ");
            inputN = Console.ReadLine();
            Console.Write("min = ");
            inputMin = Console.ReadLine();
            Console.Write("max = ");
            inputMax = Console.ReadLine();
            isValidN = int.TryParse(inputN, out numN);
            isValidMin = int.TryParse(inputMin, out numMin);
            isValidMax = int.TryParse(inputMax, out numMax);
        }

        Random random = new Random();

        for (int i = 0; i < numN; i++)
        {        
            int randomInt = random.Next(numMin, numMax);
            Console.Write(randomInt + " ");
        }
    }
}
