using System;

class Eggcelent
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int dotCount = numN + 1;
        int asteriskCount = numN - 1;
        int middleDots = numN + 1;

        Console.WriteLine("{0}{1}{0}", new string('.', dotCount), new string('*', asteriskCount));

        asteriskCount = 1;

        for (int i = 0; i < (numN / 2 - 1); i++)
        {            
            dotCount -= 2;
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dotCount), new string('*', asteriskCount), new string('.', middleDots));
            middleDots += 4;
        }

        dotCount -= 2;

        for (int i = 0; i < (numN - 2) / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dotCount), new string('*', asteriskCount), new string('.', numN + 1 + 4 * (numN / 2 - 1)));
        }  

        PrintFirstLineCrackStart();
        PrintElementOfCrack((numN * 3 - 4) / 2);
        PrintFirstLineCrackEnd();
        Console.WriteLine();

        PrintSecondLineCrackStart();
        PrintElementOfCrack((numN * 3 - 4) / 2);
        PrintSecondLineCrackEnd();
        Console.WriteLine();

        for (int i = 0; i < (numN - 2) / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dotCount), new string('*', asteriskCount), new string('.', numN + 1 + 4 * (numN / 2 - 1)));
        }

        for (int i = 0; i < (numN / 2 - 1); i++)
        {
            dotCount += 2;
            middleDots -= 4;  
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', dotCount), new string('*', asteriskCount), new string('.', middleDots));             
        }

        dotCount = numN + 1;
        asteriskCount = numN - 1;
        Console.WriteLine("{0}{1}{0}", new string('.', dotCount), new string('*', asteriskCount));
    }

    static void PrintElementOfCrack(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(".@");
        }
    }

    static void PrintFirstLineCrackStart()
    {
        Console.Write(".*@");
    }

    static void PrintFirstLineCrackEnd()
    {
        Console.Write("*.");
    }

    static void PrintSecondLineCrackStart()
    {
        Console.Write(".*");
    }

    static void PrintSecondLineCrackEnd()
    {
        Console.Write(".*.");
    }
}
