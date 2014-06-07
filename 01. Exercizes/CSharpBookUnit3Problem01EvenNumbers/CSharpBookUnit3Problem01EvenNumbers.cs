using System;

    class CSharpBookUnit3Problem01EvenNumbers
    {
        static void Main()
        {
            int number = -3;
            int checkNum = (number % 2);
            Console.WriteLine((checkNum == 0) ? "The number is even number!" : "The number is NOT even number!");
        }
    }

