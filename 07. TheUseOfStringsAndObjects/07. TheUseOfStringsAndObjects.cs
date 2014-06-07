using System;

class TheUseOfStringsAndObjects
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object twoStringsAtOne = firstString + " " + secondString;
        string castAString = (string)twoStringsAtOne;
        Console.WriteLine(castAString);
    }
}