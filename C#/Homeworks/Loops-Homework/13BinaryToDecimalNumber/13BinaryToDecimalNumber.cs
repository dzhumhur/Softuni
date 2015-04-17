using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string binary = Console.ReadLine();
        ulong binToDec = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
            binToDec += (ulong)Math.Pow(2, binary.Length - 1 - i);
        }
        Console.WriteLine(binToDec);
    }
}