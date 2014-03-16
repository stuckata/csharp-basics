using System;

class AdvancedBitExchange
{
    static void Main()
    {
        long num = 2369124121; // input n               
        int firstBitPos = 2; // input p
        int secondBitPos = 22; // input q  
        int numberOfBits = 10; // input k
        int startBitPosition = 0;
        int startExchBitPos = 0;
        int numberOfBitsMask = 0;
        if (firstBitPos < secondBitPos)
        {
            startBitPosition = firstBitPos;
            startExchBitPos = secondBitPos;
        }
        else
        {
            startBitPosition = secondBitPos;
            startExchBitPos = firstBitPos;
        }
        if (((startExchBitPos + numberOfBits) <= 32) && (startBitPosition >= 0 && numberOfBits <= 32) && (startExchBitPos >= 0))
        {
            if ((startExchBitPos - startBitPosition) >= numberOfBits)
            {
                for (int i = 0; i < numberOfBits; i++)
                {
                    numberOfBitsMask = numberOfBitsMask * 2 + 1;
                }
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
            else
            {
                Console.WriteLine("overlapping");
            }
        } else
        {
            Console.WriteLine("out of range");
        }
    }
}
