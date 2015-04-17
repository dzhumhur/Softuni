using System;

class DecToBinNumber
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());
        string binary = "";            
        int reversIndex = 0;
        while (dec >= 1)
        {
            long reminder = dec % 2;
            dec /= 2;
            binary = binary + Convert.ToString(reminder);
        }
        string[] revers= new string[binary.Length];
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            revers[reversIndex] = Convert.ToString(binary[i]);
            reversIndex++;
        }
        for (int i = 0; i < revers.Length; i++)
        {
            Console.Write(revers[i]);
        }
        Console.WriteLine();
    }
}