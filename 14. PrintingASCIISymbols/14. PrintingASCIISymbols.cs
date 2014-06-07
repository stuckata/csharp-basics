using System;

class PrintingASCIISymbols
{
    static void Main()
    {
        for (int i = 0; i <= 255; i++)
        {
            char symbol = (char)i;
            Console.Write(symbol + ", ");
        }
    }
}