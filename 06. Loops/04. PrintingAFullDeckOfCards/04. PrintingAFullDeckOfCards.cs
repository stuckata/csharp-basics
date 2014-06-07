using System;

class PrintingAFullDeckOfCards
{
    static void Main()
    {
        char clubs = (char)5;
        char diamonds = (char)4;
        char hearts = (char)3;
        char spades = (char)6;

        for (int card = 2; card <= 14; card++)
        {
            string cardName = "" + card;
            switch (card)
            {
                case 11:
                    cardName = "J";
                    break;
                case 12:
                    cardName = "Q";
                    break;
                case 13:
                    cardName = "K";
                    break;
                case 14:
                    cardName = "A";
                    break;
            }

            for (int color = 0; color <= 4; color++)
            {
                switch (color)
                {
                    case 0:
                        Console.Write("{0, 2}{1} ", cardName, clubs);
                        break;
                    case 1:
                        Console.Write("{0, 2}{1} ", cardName, diamonds);
                        break;
                    case 3:
                        Console.Write("{0, 2}{1} ", cardName, hearts);
                        break;
                    case 4:
                        Console.Write("{0, 2}{1} ", cardName, spades);
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}

