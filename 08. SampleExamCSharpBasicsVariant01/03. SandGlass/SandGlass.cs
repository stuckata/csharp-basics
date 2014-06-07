using System;

class SandGlass
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int countAsterisk = numN;
        int countPoint = 0;

        for (int line = numN / 2; line >= 0; line--)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', countPoint), new string('*', countAsterisk));
            countAsterisk -= 2;
            countPoint++;
        }

        countAsterisk += 2;
        countPoint--;

        for (int line = 1; line <= numN / 2; line++)
        {
            countAsterisk += 2;
            countPoint--;
            Console.WriteLine("{0}{1}{0}", new string('.', countPoint), new string('*', countAsterisk));
        }
    }
}


