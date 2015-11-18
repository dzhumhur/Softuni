using System;

class MagicCarNumbers
{
    static int count = 0;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };

        for (int l1 = 0; l1 < letters.Length; l1++)
        {
            for (int l2 = 0; l2 < letters.Length; l2++)
            {
                for (int a = 0; a <= 9; a++)
                {
                    CheckCarNumberForMagic("CA" + a + a + a + a + letters[l1] + letters[l2], n);
                    for (int b = 0; b <= 9; b++)
                    {
                        if (b != a)
                        {
                            CheckCarNumberForMagic("CA" + a + a + a + b + letters[l1] + letters[l2], n);
                            CheckCarNumberForMagic("CA" + a + b + b + b + letters[l1] + letters[l2], n);
                            CheckCarNumberForMagic("CA" + a + a + b + b + letters[l1] + letters[l2], n);
                            CheckCarNumberForMagic("CA" + a + b + a + b + letters[l1] + letters[l2], n);
                            CheckCarNumberForMagic("CA" + a + b + b + a + letters[l1] + letters[l2], n);
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }

    private static void CheckCarNumberForMagic(string carNumber, int n)
    {
        
        int tempWeight = 0;
        foreach (var ch in carNumber)
        {
            if (ch >= '0' && ch <= '9')
            {
                tempWeight += ch - '0';
            }
            else
            {
                tempWeight += (10 * (ch - 'A' + 1));
            }
        }

        if (tempWeight == n)
        {
            count++;
            //Console.WriteLine(carNumber);
        }
    }
}