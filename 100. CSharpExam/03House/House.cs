using System;

class House
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int dotCount = (numN - 1) / 2;
        int asteriskCount = 1;
        int dotCountMiddle = 1;

        PrintBeginingAndEnd(dotCount, asteriskCount);
        
        for (int i = 0; i < (((numN + 1) / 2) - 2); i++)
        {
            dotCount--;            
            PrintFirstHalfAndSecondHalf(dotCount, asteriskCount, dotCountMiddle);
            dotCountMiddle += 2;
        }

        PrintCentre(numN);

        dotCount = (numN) / 4;
        dotCountMiddle = ((numN - (dotCount * 2)) - 2);

        for (int i = 0; i < (((numN + 1) / 2) - 2); i++)
        {
            PrintFirstHalfAndSecondHalf(dotCount, asteriskCount, dotCountMiddle);
        }

        asteriskCount = (numN - (dotCount * 2));
        PrintBeginingAndEnd(dotCount, asteriskCount);
        
    }

    static void PrintBeginingAndEnd(int dotCount, int asteriskCount)
    {
        Console.WriteLine("{0}{1}{0}", new string('.', dotCount), new string('*', asteriskCount));
    }

    static void PrintFirstHalfAndSecondHalf(int dotCount, int asteriskCount, int dotCountMiddle)
    {
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dotCount), new string('*', asteriskCount), new string('.', dotCountMiddle));
    }

    static void PrintCentre(int asteriskCount)
    {
        Console.WriteLine(new string('*', asteriskCount));
    }

}
