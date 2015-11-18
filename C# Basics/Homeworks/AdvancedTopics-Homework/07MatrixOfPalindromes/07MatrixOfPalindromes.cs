using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        string[,] palindromesMatrix = new string[r, c];
        char letter = (char)97;
        char middleLetter = (char)97;
        for (int row = 0; row < r; row++)
        {
            if (letter > 'Z')
            {
                letter = 'A';
            }   middleLetter = letter;
            for (int col = 0; col < c; col++)
            {
                if (middleLetter > 'Z')
                {
                    middleLetter = 'A';
                }
                palindromesMatrix[row, col] = new string(letter, 1) + new string(middleLetter, 1) + new string(letter, 1);
                middleLetter++;
            }
            letter++;
            middleLetter = (char)(97 + row + 1);
        }
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                Console.Write(palindromesMatrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}