using System;

class BitwiseBooleanExpressionForBit
{
    static void Main()
    {
        int n = 62241;
        int p = 11;
        bool checkBit = ((n >> p) & 1) == 1;
        Console.WriteLine("Is the bit on position {0} of number {1} is 1?", p, n);
        Console.WriteLine(checkBit);
    }
}
