// до тука го докарах.... :)
using System;
using System.Threading;
class FallingRocks
{
    static void Main()
    {
        const int gameHeigh = 50;
        const int gameWidth = 49;
        Console.CursorVisible = false;
        Console.WindowHeight = gameHeigh;
        Console.WindowWidth = gameWidth;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        
        // dwarf
        string dwarf = "(0)";
        int dwarfPositionX = gameWidth / 2 - 1;
        int dwarfPositionY = gameHeigh - 2;
        
        // rocks
        char[] rocks = { '@', '#', '$', '%', '^', '&', '*', '+', '=', ';', '!', '<', '>' };
        int rockX; 
        int rockY = 0;
        Random randomGenPos = new Random();
        rockX = randomGenPos.Next(0, gameWidth);
        Console.SetCursorPosition(rockX, rockY);
        Random rockType = new Random();
        int symbol = rockType.Next(rocks.Length);
        Console.Write(rocks[symbol]);

        while (true)
        {
            Console.Clear();
            if (Console.KeyAvailable)
            {

                Console.SetCursorPosition(dwarfPositionX, dwarfPositionY);
                Console.Write(dwarf);
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    dwarfPositionX--;
                    if (dwarfPositionX < 0)
                    {
                        dwarfPositionX = 0;
                    }
                }

                if (key.Key == ConsoleKey.RightArrow)
                {
                    dwarfPositionX++;
                    if (dwarfPositionX > gameWidth - dwarf.Length)
                    {
                        dwarfPositionX = gameWidth - dwarf.Length;
                    }
                }
            }
            Console.SetCursorPosition(dwarfPositionX, dwarfPositionY);
            Console.Write(dwarf);

          
            Console.SetCursorPosition(rockX, rockY);

            rockY++;
            Console.Write(rocks[symbol]);

            if ((rockX == dwarfPositionX || rockX == dwarfPositionX + 1 || rockX == dwarfPositionX + 2) && rockY == dwarfPositionY)
            {
                
                Console.SetCursorPosition(gameWidth/2-7, 12);
                Console.WriteLine(new string('-', 17));
                Console.SetCursorPosition(gameWidth / 2 - 7, 13);
                Console.WriteLine("|   GAME OVER!! |");
                Console.SetCursorPosition(gameWidth / 2 - 7, 14);
                Console.WriteLine(new string('-', 17));
                break;
            }

            if (rockY == gameHeigh)
            {

                rockType = new Random();
                symbol = rockType.Next(rocks.Length);
                Console.Write(rocks[symbol]);
                randomGenPos = new Random();
                rockX = randomGenPos.Next(0, gameWidth);
                rockY = 0;
                Console.SetCursorPosition(dwarfPositionX, dwarfPositionY);
                Console.Write(dwarf);
            }
            Thread.Sleep(75);
        }
    }
}