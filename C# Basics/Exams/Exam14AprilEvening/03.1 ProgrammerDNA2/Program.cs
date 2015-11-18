using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        int width = 7;
        int dothes = width / 2;
        int count = 1;
        int innerCount = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', dothes));
            if (innerCount < width)
            {
                for (int j = 0; j < innerCount; j++)
                {
                    Console.Write(new string(letter, 1));
                    letter++;
                    if (letter == 'H')
                    {
                        letter = 'A';
                    }
                }
                innerCount += 2;
            }
            Console.Write(new string('.', dothes));
            Console.WriteLine();
            dothes--;
            if (dothes == 0)
            {
                Console.Write(letter++);
                if (letter == 'H')
                {
                    letter = 'A';
                }
                Console.Write(letter++);
                if (letter == 'H')
                {
                    letter = 'A';
                }
                Console.Write(letter++);
                if (letter == 'H')
                {
                    letter = 'A';
                }
                Console.Write(letter++);
                if (letter == 'H')
                {
                    letter = 'A';
                }
                Console.Write(letter++);
                if (letter == 'H')
                {
                    letter = 'A';
                }
                Console.Write(letter++);
                if (letter == 'H')
                {
                    letter = 'A';
                }
                Console.Write(letter++);
                if (letter == 'H')
                {
                    letter = 'A';
                }

                
            }
            

            //if (innerCount >= 1)
            //{
            //    for (int k = 0; k < innerCount; k++)
            //    {
            //        Console.Write(new string(letter, 1));
            //        letter++;
            //        if (letter == 'H')
            //        {
            //            letter = 'A';
            //        }
            //    }
            //    innerCount -= 2;
            }
        }
    }


