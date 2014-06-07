using System;

    class CSharpBookUnit3Problem03CheckingDigit
    {
        static void Main()
        {
            int number = 676589;
            int divideNum = number / 100;
            int checkThirdNum = divideNum % 10;
            Console.WriteLine("The number is: " + number);
            Console.WriteLine(checkThirdNum == 7 ? "The third digit(right to left side) of the number is 7"
                : "The third digit(right to left side) of the number is NOT 7");
        }
    }
