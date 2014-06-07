using System;

class ConvertBinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("This program convert binary to decimal number.");
        Console.WriteLine("Enter a binary integer to be converted: ");
        string inputS = Console.ReadLine();
        string[] input = new string[inputS.Length];

        for (int i = 0; i < inputS.Length; i++)
        {
            input[i] = inputS.Substring(i, 1);
        }

        int num = 0;
        double result = 0;
        
        for (int index = 0; index < input.Length; index++)
        {
            bool isValid = int.TryParse(input[index], out num);
            while (!isValid || ((num < 0) || (num > 1)))
            {
                Console.Write("Invalid input! ");
                Console.WriteLine("Enter a binary integer to be converted: ");
                input = Console.ReadLine().Split();
                isValid = int.TryParse(input[index], out num);
            }
            result += (num * Math.Pow(2, (input.Length - 1 - index)));
            result = (long)result;
        }
        Console.WriteLine("In decimal is {1}", input, result);
    }
}

