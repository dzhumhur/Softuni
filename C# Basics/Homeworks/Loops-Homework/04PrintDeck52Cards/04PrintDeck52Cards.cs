using System;

class PrintDeck52Cards
{
    static void Main()
    {
        char clubs = '\u2663';
        char diamonds = '\u2666';
        char spades = '\u2660';
        char hearts = '\u2665';
        for (int i = 1; i <= 13; i++)
        {
            switch (i)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{4}", i, clubs, diamonds, hearts, spades);
                    break;
                case 10:
                    Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{4}", 'J', clubs, diamonds, hearts, spades);
                    break;
                case 11:
                    Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{4}", 'Q', clubs, diamonds, hearts, spades);
                    break;
                case 12: 
                    Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{4}", 'K', clubs, diamonds, hearts, spades);
                    break;
                case 13: 
                    Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{4}", 'A', clubs, diamonds, hearts, spades);
                    break;
            }
        }
    }
}
