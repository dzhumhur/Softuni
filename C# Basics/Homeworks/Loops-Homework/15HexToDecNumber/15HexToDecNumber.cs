using System;

class HexToDecNumber
{
    static void Main()
    {
        string hex = Console.ReadLine();
        long dec = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case '0':
                    dec += (long)(0 * Math.Pow(16, (hex.Length - i - 1)));
                    break;
                case '1':
                    dec += (long)(1 * Math.Pow(16, (hex.Length -i - 1)));
                    break;
                case '2':
                    dec += (long)(2 * Math.Pow(16, (hex.Length -i - 1)));
                    break;
                case '3':
                    dec += (long)(3 * Math.Pow(16, (hex.Length - i - 1)));
                    break;
                case '4':
                    dec += (long)(4 * Math.Pow(16, (hex.Length - i - 1)));
                    break;
                case '5':
                    dec += (long)(5 * Math.Pow(16, (hex.Length - i - 1)));
                    break;
                case '6':
                    dec += (long)(6 * Math.Pow(16, (hex.Length - i - 1)));
                    break;
                case '7':
                    dec += (long)(7 * Math.Pow(16, (hex.Length - i - 1)));
                    break;
                case '8':
                    dec += (long)(8 * Math.Pow(16, (hex.Length - i - 1)));
                    break;
                case '9':
                    dec += (long)(9 * Math.Pow(16, (hex.Length - i - 1)));
                    break;
                case 'A':
                    dec += (long)(10 * Math.Pow(16, (hex.Length - i - 1)));
                    break;
                case 'B':
                    dec += (long)(11 * Math.Pow(16, (hex.Length - i - 1)));
                    break;
                case 'C':
                    dec += (long)(12 * Math.Pow(16, (hex.Length - i - 1)));
                    break;
                case 'D':
                    dec += (long)(13 * Math.Pow(16, (hex.Length - i - 1)));
                    break;
                case 'E':
                    dec += (long)(14 * Math.Pow(16, (hex.Length - i - 1)));
                    break;
                case 'F':
                    dec += (long)(15 * Math.Pow(16, (hex.Length -i - 1)));
                    break;
            }
            
        }
        Console.WriteLine(dec);
    }
}