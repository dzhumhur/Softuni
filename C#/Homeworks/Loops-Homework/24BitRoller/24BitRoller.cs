using System;

class BitRoller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        char[] bits = Convert.ToString(n, 2).PadLeft(19, '0').ToCharArray();

        f = 19 - 1 - f;

        for (int i = 0; i < r; i++)
        {
            char[] newBits = new char[bits.Length];

            for (int pos = 0; pos < bits.Length; pos++)
            {
                if (pos == f)
                {
                    newBits[pos] = bits[pos];
                }
                else
                {
                    int newPos = (pos + 1) % bits.Length;
                    if (newPos == f)
                    {
                        newPos = (newPos + 1) % bits.Length;
                    }
                    newBits[newPos] = bits[pos];
                }
            }
            for (int j = 0; j < bits.Length; j++)
            {
                bits[j] = newBits[j];
            }
        }
        int result = Convert.ToInt32(new string(bits), 2);
        Console.WriteLine(result);
    }
}