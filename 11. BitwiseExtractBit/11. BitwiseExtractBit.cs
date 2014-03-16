using System;

class BitwiseExtractBit
{
    static void Main()
    {
        int n = 62241;
        int bitNumber = 3;
        int checkBit = (n >> bitNumber) & 1;
        Console.WriteLine("The third bit is: {0}", checkBit);
    }
}
