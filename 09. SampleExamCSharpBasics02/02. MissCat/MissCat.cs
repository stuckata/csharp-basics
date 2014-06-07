using System;

class MissCat
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int[] catVotesByNum = new int[numN];
        int[] catNum = new int[10];
        int bestVotes = 0;
        int bestCat = 0;

        for (int i = 0; i < catVotesByNum.Length; i++)
        {
            catVotesByNum[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < catVotesByNum.Length; i++)
        {
            for (int i2 = 1; i2 <= catNum.Length; i2++)
            {
                if (catVotesByNum[i] == i2)
                {
                    catNum[i2 - 1]++;
                }
            }
        }

        for (int i = 1; i <= catNum.Length; i++)
        {
            if (bestVotes < catNum[i - 1])
            {
                bestVotes = catNum[i - 1];
                bestCat = i;
            }
        }

        Console.WriteLine(bestCat);
    }
}
