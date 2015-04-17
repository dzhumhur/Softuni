using System;
using System.Collections.Generic;
using System.Linq;
class Problem1
{
    static void Main()
    {
        int maxIncome = 233160; 
        string[] firstLineAsString = Console.ReadLine().Split(' ');
        string[] secondLineAsString = Console.ReadLine().Split(' ');
        string[] thirdLineAsString = Console.ReadLine().Split(' ');

        int[] firstLine = new int[firstLineAsString.Length];
        firstLine = Array.ConvertAll(firstLineAsString, int.Parse);

        int[] secondLine = new int[secondLineAsString.Length];
        secondLine = Array.ConvertAll(secondLineAsString , int.Parse);

        int[] thirdLine = new int[thirdLineAsString.Length];
        thirdLine = Array.ConvertAll(thirdLineAsString , int.Parse);

        double firstFrequently = 7000 * 0.3;
        double secondFrequently = 3500 * 0.3;
        double thirdFrequently = 1000 * 0.3;



        double withMealFirst = 7000 + (7000 * 0.005);
        double withMealSecond = 3500 +  (3500* 0.005);
        double withMealThird =  1000 + (1000 * 0.005);
       

       
        firstLine[0] -= firstLine[1] + firstLine[2];
        secondLine[0] -= secondLine[1] + secondLine[2];
        thirdLine[0] -= thirdLine[1] + thirdLine[2];

        double firsLineIncome = (firstLine[0] * 7000) + (firstLine[1] * firstFrequently) + (firstLine[2] * withMealFirst);
        double secondLineIncome = (secondLine[0] * 3500) + (secondLine[1] * secondFrequently ) + (secondLine[2] * withMealSecond);
        double thirdLineIncome = (thirdLine[0] * 1000) + (thirdLine[1] * thirdFrequently) + (thirdLine[2] * withMealThird);


        double sumIncome = firsLineIncome + secondLineIncome + thirdLineIncome;
        Console.WriteLine(Math.Floor(sumIncome));
        double diff = maxIncome - Math.Floor(sumIncome);
        Console.WriteLine(diff);


        
    }
}

