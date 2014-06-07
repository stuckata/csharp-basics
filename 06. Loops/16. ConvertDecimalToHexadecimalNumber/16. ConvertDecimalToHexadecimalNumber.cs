using System;

class ConvertDecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.WriteLine("This program convert decimal number to its hexadecimal representation.");
        Console.Write("Enter positive integer decimal number: ");
        string input = Console.ReadLine();
        long num = 0;
        int temp = 0;
        string result = "";
        string tempHex = "";
        bool isValid = long.TryParse(input, out num);

        while (!isValid || !(num >= 0))
        {
            Console.WriteLine("Invalid Input! Enter positive integer decimal number: ");
            input = Console.ReadLine();
            isValid = long.TryParse(input, out num);
        }

        if (num == 0)
        {
            Console.WriteLine("Hexadecimal representation is: {0}", num);
            return;
        }

        while (num >= 1)
        {
            temp = (int)(num % 16);
            num = (num / 16);
            switch (temp)
            {
                case 0:
                    tempHex = "0";
                    break;
                case 1:
                    tempHex = "1";
                    break;
                case 2:
                    tempHex = "2";
                    break;
                case 3:
                    tempHex = "3";
                    break;
                case 4:
                    tempHex = "4";
                    break;
                case 5:
                    tempHex = "5";
                    break;
                case 6:
                    tempHex = "6";
                    break;
                case 7:
                    tempHex = "7";
                    break;
                case 8:
                    tempHex = "8";
                    break;
                case 9:
                    tempHex = "9";
                    break;
                case 10:
                    tempHex = "A";
                    break;
                case 11:
                    tempHex = "B";
                    break;
                case 12:
                    tempHex = "C";
                    break;
                case 13:
                    tempHex = "D";
                    break;
                case 14:
                    tempHex = "E";
                    break;
                case 15:
                    tempHex = "F";
                    break;
            }
            result = tempHex + result;
        }
        Console.WriteLine("Hexadecimal representation is: {0}", result);
    }
}

