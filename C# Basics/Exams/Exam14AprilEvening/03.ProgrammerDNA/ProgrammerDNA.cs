using System;
class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine().ToUpper());
        char firstCharacter = 'A';
        char lastCharacter = 'G';
        int first = 65;
        int last = 71;
        int width = 7;
        int outerDots = width / 2;
        int innerCount = 1;
        int secondInner = width - 2;
        int innerChars = 1;
        int bottomDots = 1;
        int middledots = outerDots;
        int thirdInner = 1;
        int temDots = 1;
        int negativetempDots = width -2;

        for (int i = 1; i <= n; i++)
        {
            if (i <= (width/2) + 1)
            {
                Console.Write(new string('.', outerDots));

                for (int j = 0; j < innerCount; j++)
                {
                    Console.Write(new string((char)letter, 1));
                    letter++;
                    if (letter == 'H')
                    {
                        letter = 'A';
                    }
                }
                innerCount += 2;
            
                Console.Write(new string('.', outerDots));
                
                outerDots--;
                Console.WriteLine();
            }

            else if (i <= width)
            {
                Console.Write(new string('.', bottomDots));

                for (int j = 0; j < secondInner; j++)
                {
                    Console.Write(new string((char)letter, 1));
                    letter++;
                    if (letter == 'H')
                    {
                        letter = 'A';
                    }
                }
                secondInner -= 2;

                Console.Write(new string('.', bottomDots));

                bottomDots++;
                Console.WriteLine();
            }
            else if (i <=n)
            {
                Console.Write(new string('.', middledots));

                for (int j = 0; j < thirdInner; j++)
                {
                    Console.Write(new string((char)letter, 1));
                    letter++;
                    if (letter == 'H')
                    {
                        letter = 'A';
                    }
                }
                thirdInner += 2;

                Console.Write(new string('.', middledots));

                middledots--;
                Console.WriteLine();

                if (middledots == -1)
                {
                    Console.Write(new string('.', temDots));

                for (int j = 0; j < negativetempDots; j++)
                {
                    Console.Write(new string((char)letter, 1));
                    letter++;
                    if (letter == 'H')
                    {
                        letter = 'A';
                    }
                }
                negativetempDots += 2;
            
                Console.Write(new string('.', temDots));
                
                temDots--;
                Console.WriteLine();
                }
                else
                {

                }
            }
        }
    }
}

