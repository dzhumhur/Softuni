using System;

class BitsExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint mask = 7;
        uint bit3To5 = (n & (mask << 3)) >> 3;
        uint bit24To26 = (n & (mask << 24)) >> 24;
        n = n & ~(mask << 3);
        n = n & ~(mask << 24);
        n = n | (bit3To5 << 24);
        n = n | (bit24To26 << 3);
        Console.WriteLine(n);
    }
}