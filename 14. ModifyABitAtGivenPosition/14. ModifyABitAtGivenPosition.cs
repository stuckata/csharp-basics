using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int n = 62241;
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        int p = 11;
        int v = 0;
        int mask = 0;
        if (v == 0)
        {
            v = 1;
            mask = ~(v << p);
            n = mask & n;
        } else
        {
            mask = (v << p);
            n = mask | n;
        }
        Console.WriteLine(n);
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
    }
}
