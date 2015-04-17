using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int totaLength = 0;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            int length = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();

            if (measure == "meters")
            {
                length *= 100;
            }

            if (length >= 20)
            {
                count++;
                totaLength += length;
            }
        }
        totaLength -= ((--count) * 3);
        Console.WriteLine(totaLength / 504);
        Console.WriteLine(totaLength % 504); 
    }
}
