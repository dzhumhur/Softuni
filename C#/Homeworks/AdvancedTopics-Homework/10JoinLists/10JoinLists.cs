using System;
using System.Collections.Generic;
//20 40 10 10 30 80
//25 20 40 30 10	            10 20 25 30 40 80

class JoinLists
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split(' ');
        List<int> firstList = new List<int>();
        foreach (var item in firstLine)
        {
            firstList.Add(int.Parse(item));
        }
        string[] secondLine = Console.ReadLine().Split(' ');
        List<int> secondList = new List<int>();
        CheckForEqualsInFirsList(firstList);

        foreach (var item in secondLine)
        {
            firstList.Add(int.Parse(item));
        }
        CheckForEqualsInFirsList(firstList);
        foreach (var item in firstList)
        {
            Console.Write(item + " ");
        }

    }

    private static void CheckForEqualsInFirsList(List<int> firstList)
    {
        firstList.Sort();//20 40 10 10 30 80 --> 10 10 20 30 40 80

        int previosNum = firstList[0];
        for (int i = 1; i < firstList.Count; i++)
        {
            if (firstList[i] != previosNum)
            {
                previosNum = firstList[i];

            }
            else
            {
                firstList.RemoveAt(i);
                i--;
            }
        }
    }


}