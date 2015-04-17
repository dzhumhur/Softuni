using System;
using System.Collections.Generic;

class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cableLenght; string measure;
        int minLenght = 20;
        int sumLenght = 0;
        int count = 0;
        int studentCables; int remainingCable;
        for (int i = 0; i < n; i++)
        {
            cableLenght = int.Parse(Console.ReadLine());
            measure = Console.ReadLine();
            if (measure == "meters")
            {
                cableLenght *= 100;
            }
            if (cableLenght >= minLenght)
            {
                sumLenght += cableLenght;
                count++;
            }
        }
        sumLenght = sumLenght - 3 * (count-1);

        studentCables = sumLenght / 504;
        remainingCable = sumLenght % 504;
        Console.WriteLine(studentCables);
        Console.WriteLine(remainingCable);
    }
}