using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int number = -3;
        int checkNum = (number % 2);
        Console.WriteLine((checkNum == 0) ? "The integer is even!" : "The integer is odd!");
    }
}
