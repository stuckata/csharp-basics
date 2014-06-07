using System;
using System.Text;

class IsoscelesTriangleOfSymbols
{
    static void Main()
    {
        char copyrightSymbol = '\u00a9';
        Console.OutputEncoding = Encoding.UTF8;
        string oneSpace = " ";
        Console.WriteLine(oneSpace + oneSpace + oneSpace + copyrightSymbol);
        Console.WriteLine(oneSpace + oneSpace + copyrightSymbol + oneSpace + copyrightSymbol);
        Console.WriteLine(oneSpace + copyrightSymbol + oneSpace + oneSpace + oneSpace + copyrightSymbol);
        Console.WriteLine(copyrightSymbol + oneSpace + copyrightSymbol + oneSpace + copyrightSymbol + oneSpace + copyrightSymbol);
    }
}