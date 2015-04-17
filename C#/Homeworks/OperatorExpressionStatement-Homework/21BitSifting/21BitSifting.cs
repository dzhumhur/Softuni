using System;

class BitSifting
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        byte sievesNumbers = byte.Parse(Console.ReadLine());

        for (byte i = 0; i < sievesNumbers; i++)
        {
            ulong sieves = ulong.Parse(Console.ReadLine());
            number = (number ^ sieves) & number;
        }

        ulong result = 0;
        for (int i = 0; i < 63; i++)
        {
            ulong bit = number >> i;
            bit = bit & 1;
            result += bit;
            
        }
        Console.WriteLine(result);
    }
}