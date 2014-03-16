using System;

class BitExchange
{
    static void Main()
    {
        long num = 2369124121;
        int positionIndex = 7; // Hex: 111
        int startBitPosition = 3;
        int startExchBitPos = 24;
        int firstBitsMask = positionIndex << startBitPosition;
        long firstBits = firstBitsMask & num;
        int exchangeBitsMask = positionIndex << startExchBitPos;
        long exchangeBits = exchangeBitsMask & num;
        int clearBits = ~(firstBitsMask | exchangeBitsMask); // integer to clear the possitions of bits for exchange
        
        num = num & clearBits; // now the positions for exchange are with value 000
        firstBits = firstBits << (startExchBitPos - startBitPosition);
        exchangeBits = exchangeBits >> (startExchBitPos - startBitPosition);
        num = num | firstBits;
        num = num | exchangeBits;
        
        Console.WriteLine(num);
    }
}
