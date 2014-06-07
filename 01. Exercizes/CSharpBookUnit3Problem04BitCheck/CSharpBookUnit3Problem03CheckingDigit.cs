using System;

    class CSharpBookUnit3Problem03CheckingDigit
    {
        static void Main()
        {
            int numberInDec = 28;
            int numberCheck = 8; // 8 because in hex is 1000
            int result = numberInDec & numberCheck;
            Console.WriteLine("The number is " + numberInDec);
            Console.WriteLine(result == 0 ? "The third bit of the number is 0" : "The third bit of the number is 1");
        }
    }
