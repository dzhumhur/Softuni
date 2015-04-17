using System;

class DecToHexNumber
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());
        long decDiv = dec;
        int count = 0;
        while (decDiv > 0)
        {
            decDiv /= 16;
            count++;
        }
        long[] reminders = new long[count];
        decDiv = dec;
        for (int i = 0; i < reminders.Length; i++)
        {
            dec = dec % 16;
            reminders[i] = dec;
            decDiv /= 16;
            dec = decDiv;
        }
        for (int i = reminders.Length - 1; i >= 0; i--)
        {
            switch (reminders[i])
            {
                case 0:
                    Console.Write('0');
                    break;
                case 1:
                    Console.Write('1');
                    break;
                case 2:
                    Console.Write('2');

                    break;
                case 3:
                    Console.Write('3');

                    break;
                case 4:
                    Console.Write('4');

                    break;
                case 5:
                    Console.Write('5');

                    break;
                case 6:
                    Console.Write('6');

                    break;
                case 7:
                    Console.Write('7');

                    break;
                case 8:
                    Console.Write('8');

                    break;
                case 9:
                    Console.Write('9');

                    break;
                case 10:
                    Console.Write('A');

                    break;
                case 11:
                    Console.Write('B');

                    break;
                case 12:
                    Console.Write('C');

                    break;
                case 13:
                    Console.Write('D');

                    break;
                case 14:
                    Console.Write('E');

                    break;
                case 15:
                    Console.Write('F');
                    break;
            }
        }
        Console.WriteLine();
    }
}