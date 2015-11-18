using System;

class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] strings = new string[n];

        for (int i = 0; i < strings.Length; i++)
        {
            strings[i] = Console.ReadLine();
        }

        int maxLenght = int.MinValue;
        string areaStr = strings[0];
        int count = 0;
        string curentStr = strings[0];

        for (int i = 0; i < strings.Length; i++)
        {
            if (curentStr == strings[i])
            {
                count++;
            }
            else
            {
                curentStr = strings[i];
                count = 1;
            }

            if (count > maxLenght)
            {
                maxLenght = count;
                areaStr = curentStr;
            }

        }

        PrintResult(maxLenght, areaStr);

    }

    static void PrintResult(int maxLenght, string areaStr)
    {
        Console.WriteLine(maxLenght);
        for (int i = 0; i < maxLenght; i++)
        {
            Console.WriteLine(areaStr);
        }
    }

}