using System;
using System.Collections.Generic;
using System.Linq;
class OddAndEvenSum
{
    static void Main()
    {
        string[] input = Console.ReadLine().ToLower().Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries);
        string processedInput = string.Join("", input);
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());
        ulong oddResult = 0;
        ulong evenResult = 0;
        int currentJumpPos = 1;
        //Odd characters
        for (int i = 0; i < processedInput.Length; i+=2)
        {
            ulong currentSybmbolCode = (ulong)processedInput[i];
            if (currentJumpPos == oddJump)
            {
                oddResult *= currentSybmbolCode;
                currentJumpPos = 1;
            }
            else
            {
                oddResult += currentSybmbolCode;
                currentJumpPos++;
            }
           
        }
        currentJumpPos = 1;
        //Even Characters
        for (int i = 0; i < processedInput.Length; i += 2)
        {
            ulong currentSybmbolCode = (ulong)processedInput[i];
            if (currentJumpPos == evenJump)
            {
                evenResult *= currentSybmbolCode;
                currentJumpPos = 1;
            }
            else
            {
                evenResult += currentSybmbolCode;
                currentJumpPos++;
            }

        }

        Console.WriteLine("Odd: {0:X}",oddResult);
        Console.WriteLine("Even: {0:X}",evenResult);
    }
}

