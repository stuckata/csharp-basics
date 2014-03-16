using System;

class BitwiseExtractBitAtCertainIndex
{
    static void Main()
    {
        int n = 62241;
        int p = 11;
        int checkBit = (n >> p) & 1;
        Console.WriteLine("The bit on position {0} of number {1} is: {2}", p, n, checkBit);
    }
}
