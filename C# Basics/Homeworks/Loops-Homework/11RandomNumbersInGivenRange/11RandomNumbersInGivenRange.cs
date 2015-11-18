using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random randomGen = new Random();

        for (int i = 0; i < n; i++)
        {
            int randomNum = randomGen.Next(min, max);
            Console.Write("{0} ", randomNum);
        }
    }
}