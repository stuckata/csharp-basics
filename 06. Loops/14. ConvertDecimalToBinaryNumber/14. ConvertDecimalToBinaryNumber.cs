using System;

class ConvertDecimalToBinaryNumber
{
    static void Main()
    {
        Console.WriteLine("This program convert decimal to binary number");
        Console.WriteLine("Enter the integer number n to be converted: ");
        Console.Write("n = ");
        string input = Console.ReadLine();
        long numN = 0;
        bool isValid = long.TryParse(input, out numN);
        long tempBit = 0;
        string result = "";
        string temp = "";

        while (!isValid)
        {
            Console.WriteLine("Invalid Input! Enter new integer number: ");
            Console.Write("n = ");
            input = Console.ReadLine();
            isValid = long.TryParse(input, out numN);
        }

        if (numN == 0)
        {
            result = "" + numN;
            Console.WriteLine("The binary representation is: {0}", result);
            return;
        }

        while (numN > 0)
        {
            tempBit = (numN % 2);
            numN = (numN / 2);
            temp = "" + tempBit;
            result = temp + result;
        }
        Console.WriteLine("The binary representation is: {0}", result);
    }
}

