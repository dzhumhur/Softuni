using System;

class BitsExchange
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        if (Math.Max(p, q) + k - 1 > 31)
        {
            Console.WriteLine("out of range");
        }
        else if (Math.Min(p, q) + k - 1 >= Math.Max(p, q))
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            for (int i = p; i <= p + k - 1; i++)
            {
                uint mask = 1;
                ulong bitQ = (n & (mask << q)) >> q;
                ulong bitP = (n & (mask << i)) >> i;
                n = n & ~(mask << i);
                n = n & ~(mask << q);
                n = n | (bitP << q);
                n = n | (bitQ << i);
                q++;
            }
            Console.WriteLine(n);
        }
    }
}