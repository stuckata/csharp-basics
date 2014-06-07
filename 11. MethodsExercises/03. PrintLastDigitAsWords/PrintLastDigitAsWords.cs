using System;

class PrintLastDigitAsWords
{
    static void Main()
    {
        Console.WriteLine("This program will print the last digit of integer you enter as word.");

        int num = int.Parse(Console.ReadLine());
        int lastDigit = FindLastDigit(num);
        PrintLastDigitAsWord(lastDigit);
    }

    static void PrintInput()
    {
        Console.Write("Enter the number: ");
    }

    static int FindLastDigit(int num)
    {
        int lastDigit = (num % 10);
        return lastDigit;
    }

    static void PrintLastDigitAsWord(int num)
    {
        switch (num)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("Something is wrong!");
                break;
        }
    }
}
