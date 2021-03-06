﻿using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        // binary representation of n;
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0')); 
        
        // move bits of n to right till bit #3 get to end;
        int nMoveRight = n >> 3;
        Console.WriteLine(Convert.ToString(nMoveRight, 2).PadLeft(16, '0'));

        // Logical conjunction - results is true(1) if both operands are true, else result is false(0);
        int result = nMoveRight & 1;
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));

        Console.WriteLine(result);
    }
}