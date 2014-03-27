using System;

class ConvertHexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("This program convert hexadecimal to decimal numbers.");
        Console.Write("Enter number in hex using only capital letters: ");
        string inputS = Console.ReadLine();
        string[] input = new string[inputS.Length];
        int tempHex = 0;
        double tempNum = 0;
        long result = 0;
        int counter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            input[i] = inputS.Substring(i, 1);
        }
        for (int i = input.Length - 1; i >= 0; i--)
        {
            switch (input[i])
            {
                case "0":
                    tempHex = 0;
                    break;
                case "1":
                    tempHex = 1;
                    break;
                case "2":
                    tempHex = 2;
                    break;
                case "3":
                    tempHex = 3;
                    break;
                case "4":
                    tempHex = 4;
                    break;
                case "5":
                    tempHex = 5;
                    break;
                case "6":
                    tempHex = 6;
                    break;
                case "7":
                    tempHex = 7;
                    break;
                case "8":
                    tempHex = 8;
                    break;
                case "9":
                    tempHex = 9;
                    break;
                case "A":
                    tempHex = 10;
                    break;
                case "B":
                    tempHex = 11;
                    break;
                case "C":
                    tempHex = 12;
                    break;
                case "D":
                    tempHex = 13;
                    break;
                case "E":
                    tempHex = 14;
                    break;
                case "F":
                    tempHex = 15;
                    break;
                default:
                    Console.WriteLine("Invalid Input! Start program again and ensure input data!");
                    return;
            }         
            tempNum = (tempHex * Math.Pow(16, counter));
            result += (long)tempNum;
            counter++;
        }
        Console.WriteLine("Number in decimal: " + result);
    }
}

