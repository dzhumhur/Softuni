using System;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int bit = 0;
        for (int i = 0; i < n; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int bitPosition = 7; bitPosition >= 0; bitPosition--)
            {
                if ((bit % step == 1) || (step == 1 && bit > 0))
                {
                    numbers = numbers | (1 << bitPosition);
                }
                bit++;
            }
            Console.WriteLine(numbers);
        }
    }
}