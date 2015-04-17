using System;

class SumOfElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int isBigger = int.MinValue;
        int sum = 0;

        for (int index = 0; index < numbers.Length; index++)
        {
            int num = int.Parse(numbers[index]);
            sum += num;
            if (num > isBigger)
            {
                isBigger = num;
            }
        }

        if (sum - isBigger == isBigger)
        {
            Console.WriteLine("Yes, sum={0}", isBigger);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sum - 2 *isBigger));
        }
    }
}