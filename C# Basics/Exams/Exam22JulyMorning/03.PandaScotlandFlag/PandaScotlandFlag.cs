using System;
using System.Collections.Generic;
using System.Linq;
class PandaScotlandFlag
{
   
    static void Main()
    {
        
        int input = int.Parse(Console.ReadLine());
        char letter = 'A';

        for (int i = 0, j = input - 2; i < input / 2; i++,j-=2)
        {
            letter = Check(letter);
            Console.Write(new string('~',i) + new string(letter++,1));
            letter = Check(letter);
            Console.Write(new string('#',j) + new string(letter++,1) + new string('~',i));
            letter = Check(letter);
            Console.WriteLine();
        }

        letter = Check(letter);
        Console.WriteLine(new string('-', input/2) + (letter++) + new string('-',input/2));
        letter = Check(letter);

        for (int i = input/2 -1, j = 1; i >= 0; i--,j+=2)
        {
            letter = Check(letter);
            Console.Write(new string('~', i) + new string(letter++, 1));
            letter = Check(letter);
            Console.Write(new string('#', j) + new string(letter++, 1) + new string('~', i));
            letter = Check(letter);
            Console.WriteLine();
        }
    }

    private static char Check(char letter)
    {
        if (letter > 'Z')
        {
            letter = 'A';
        }
        return letter;
    }
}

