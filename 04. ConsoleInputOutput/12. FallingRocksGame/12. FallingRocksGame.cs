using System;
using System.Collections.Generic;
using System.Threading;
using _12.FallingRocksGame;

class FallingRocksGame
{
    static void Main()
    {
        char[] symbols = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        string dwarf = "(0)";

        int rowCount = 20;
        int colCount = Console.BufferWidth;

        //Console.ForegroundColor = ConsoleColor.Green;

        char[,] buffer = new char[rowCount, colCount];
        char[,] playField = new char[rowCount, colCount];

        Random random = new Random();

        int count = 0;
        while (count < 60)
        {
            count++;

            playField = new char[rowCount, colCount];

            int symCountPerRow = random.Next(1, 5);
            int symIdx = 0;
            int symPosition = 0;
            for (int i = 0; i < symCountPerRow; i++)
            {
                symIdx = random.Next(0, symbols.Length);
                symPosition = random.Next(0, colCount);
                playField[0, symPosition] = symbols[symIdx];
                //Console.SetCursorPosition(symPosition, 0);
                //Console.Write(symbols[symIdx]);          
            }

            for (int x = 0; x < buffer.GetLength(0) - 1; x ++)
            {
                for (int y = 0; y < buffer.GetLength(1); y ++)
                {
                    playField[x + 1, y] = buffer[x, y];
                }
            }

            for (int x = 0; x < playField.GetLength(0); x++)
            {
                for (int y = 0; y < playField.GetLength(1); y++)
                {
                    buffer[x, y] = playField[x, y];
                }
            }

            Console.Clear();

            for (int x = 0; x < playField.GetLength(0); x ++)
            {
                for (int y = 0; y < playField.GetLength(1); y ++)
                {
                    Console.Write(playField[x, y]);
                }
            }


            Thread.Sleep(1500);
        }
        Console.WriteLine();
       
    }
   
}





