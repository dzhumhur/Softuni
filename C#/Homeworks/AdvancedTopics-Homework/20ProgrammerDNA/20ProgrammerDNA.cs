using System;

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        
        char dot = '.';
        
        int diff = 0;
        int width = 7;
        int middle = width / 2;
        int diffCounter = 0;

        for (int rows = 0; rows < n; rows++)
        {
            for (int i = 0; i < width; i++)
            {
                if (i >= middle - diff && i <= middle + diff)
                {
                    Console.Write(letter);
                    if (letter > 70)
                    {
                        letter = (char)65;
                    }
                    else
                    {
                        letter++;
                    }
                }
                else
                {
                    Console.Write(dot);
                }
            }
            if (diffCounter >= middle)
            {
                diff--;
            }
            else
            {
                diff++;
            }
            diffCounter++;
            if (diffCounter == width)
            {
                diffCounter = 0;
                diff++;
            }
            Console.WriteLine();
        }
    }
}