using System;

class ForestRoad
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        //pathLength = 2 * numN - 1;

        for (int i = - (numN - 1); i <= (numN - 1); i++)
        {
            Console.WriteLine("{0}{1}{2}", new string ('.', ((numN - 1) - Math.Abs(i))), new string ('*', 1), new string('.', Math.Abs(i)));
        }
    }
}
