using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));

        int nMoveRight = n >> p;
        bool isbitequal1 = (nMoveRight & 1) == 1;
        Console.WriteLine(isbitequal1);
    }
}