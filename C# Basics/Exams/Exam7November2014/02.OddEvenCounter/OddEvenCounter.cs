using System;
using System.Collections.Generic;
using System.Linq;
class OddEvenCounter
{
    static void Main()
    {
        int setsCount = int.Parse(Console.ReadLine());
        int numbersCount = int.Parse(Console.ReadLine());
        string oddEvenInput = Console.ReadLine();

        List<int> numbers = new List<int>();
        List<int> oddOrEvenSum = new List<int>();
        string[] setsAsString = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth" };

        int oddEvenCounter = 0;
        int maxElement = int.MinValue;
        int maxElementIndex = 0;
        bool isFind = false;

        for (int i = 0, j = 1; i < setsCount * numbersCount; i++, j++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));

            if (oddEvenInput == "odd")
            {
                if (numbers[i] % 2 != 0)
                {
                    isFind = true;
                    oddEvenCounter++;
                }
                if (j % numbersCount == 0)
                {
                    oddOrEvenSum.Add(oddEvenCounter);
                    oddEvenCounter = 0;
                }
            }
            else
            {
                if (numbers[i] % 2 == 0)
                {
                    isFind = true;
                    oddEvenCounter++;
                }
                if (j % numbersCount == 0)
                {
                    oddOrEvenSum.Add(oddEvenCounter);
                    oddEvenCounter = 0;
                }
            }

        }

        for (int i = 0; i < oddOrEvenSum.Count; i++)
        {
            if (oddOrEvenSum[i] > maxElement)
            {
                maxElement = oddOrEvenSum[i];
                maxElementIndex = i;
            }
        }

        if (isFind)
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}",setsAsString[maxElementIndex], oddEvenInput, maxElement);
        }
        else
        {
            Console.WriteLine("No");
        }

    }
}
