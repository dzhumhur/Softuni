using System;

class OddEvenElements
{
    static void Main()
    {

        string[] number = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        decimal[] nums = new decimal[number.Length];
        for (int i = 0; i < number.Length; i++)
        {
            nums[i] = decimal.Parse(number[i]);
        }

        decimal oddSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;
        for (int i = 0; i < nums.Length; i+=2)
        {
            oddSum += nums[i];
            if (nums[i] <= oddMin)
            {
                oddMin = nums[i];
            }
            if (nums[i] >= oddMax)
            {
                oddMax = nums[i];
            }
        }

        decimal evenSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;
        for (int i = 1; i < nums.Length; i += 2)
        {
            evenSum += nums[i];
            if (nums[i] <= evenMin)
            {
                evenMin = nums[i];
            }
            if (nums[i] >= evenMax)
            {
                evenMax = nums[i];
            }
        }
        if (nums.Length >= 2)
        {
            Console.WriteLine
            ("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum={3:0.##}, EvenMin={4:0.##}, EvenMax={5:0.##}",
            oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }
        else if (nums.Length == 1)
        {
            Console.WriteLine
            ("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum=No, EvenMin=No, EvenMax=No",
            oddSum, oddMin, oddMax);
        }
        else if (nums.Length == 0)
        {
            Console.WriteLine
            ("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");

        }

    }
}