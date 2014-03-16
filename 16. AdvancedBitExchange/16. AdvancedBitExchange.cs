using System;

class AdvancedBitExchange
{
    static void Main()
    {

        long num = 33333333333;
        int numberOfBits = 33;
        int numberOfBitsMask = 0;
        for (int i = 0; i < numberOfBits; i++)
        {
            numberOfBitsMask = numberOfBitsMask * 2 + 1;
        }
        int startBitPosition = 0;
        int startExchBitPos = -1;

        int firstBitsMask = numberOfBitsMask << startBitPosition;
        long firstBits = firstBitsMask & num;
        int exchangeBitsMask = numberOfBitsMask << startExchBitPos;
        long exchangeBits = exchangeBitsMask & num;
        int clearBits = ~(firstBitsMask | exchangeBitsMask); // integer to clear the possitions of bits for exchange

        num = num & clearBits; // now the positions for exchange are with value 000
        firstBits = firstBits << (startExchBitPos - startBitPosition);
        exchangeBits = exchangeBits >> (startExchBitPos - startBitPosition);
        num = num | firstBits;
        num = num | exchangeBits;

        Console.WriteLine(num);
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
    }
}
