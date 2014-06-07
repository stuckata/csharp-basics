using System;

class UnicodeValue
{
    static void Main()
    {
        //The other way to use Unicode Value for Symbol is to cast it from integral type.
        //char symbolUnicodeValue = (char)72; 
        char symbolUnicodeValue = '\x0048';
        Console.WriteLine("The unicode value of 0048 is: {0}", symbolUnicodeValue);
    }
}