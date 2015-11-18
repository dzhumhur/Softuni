using System;

class BitKiller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string binary = "";
        string num = "";
        
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            num = Convert.ToString(number, 2).PadLeft(8, '0');
            binary += num;
        }

        int index = 1;
        char[] bit = binary.ToCharArray();
        binary = "";
        for (int i = 0; i < bit.Length; i++)
        {
            if (i == index)
            {
                index += step;
            }
            else
            {
                binary += bit[i];
            }
        }
        if (binary.Length % 8 != 0)
        {
            binary += new string('0', 8 - (binary.Length % 8));
        }
        for (int i = 0; i < binary.Length; i+=8)
        {
            string newnums = binary.Substring(i, 8);
            Console.WriteLine(Convert.ToUInt32(newnums, 2));
        }

    }
}