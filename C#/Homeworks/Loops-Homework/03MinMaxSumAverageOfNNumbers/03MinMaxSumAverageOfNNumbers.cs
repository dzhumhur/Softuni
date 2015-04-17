using System;

class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double sum = 0;
        double min = double.MaxValue;
        double max = double.MinValue;

        for (double i = 0; i < n; i++)
        {
            double element = double.Parse(Console.ReadLine());
            sum += element;
            if (element>max)
            {
                max = element;
            }
            if (element<min)
            {
                min = element;
            }
        }
        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("avg = {0:0.00}", sum / n);

    }
}