using System;

class Pairs
{
    static void Main()
    {
        string[] number = Console.ReadLine().Split(' ');
        int[] sums = new int[number.Length / 2];
        double maxDiff = 0;
        for (int nums = 0, sum = 0; nums < number.Length; nums += 2, sum++)
        {
            sums[sum] = int.Parse(number[nums]) + int.Parse(number[nums + 1]);
        }
        for (int i = 0; i < sums.Length-1; i++)
        {
            if (Math.Abs(sums[i] - sums[i+1]) > maxDiff)
            {
                maxDiff = Math.Abs(sums[i] - sums[i + 1]);
            }
        }
        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value={0}", sums[0]);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}