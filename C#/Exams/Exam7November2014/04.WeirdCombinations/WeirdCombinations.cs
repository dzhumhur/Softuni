using System;
using System.Collections.Generic;
using System.Linq;
class WeirdCombinations
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        int counter = -1;
        bool isFind = false;

        for (int i1 = 0; i1 < 5; i1++)
        {
            for (int i2 = 0; i2 < 5; i2++)
            {
                for (int i3 = 0; i3 < 5; i3++)
                {
                    for (int i4 = 0; i4 < 5; i4++)
                    {
                        for (int i5 = 0; i5 < 5; i5++)
                        {
                            string result = "" + input[i1] + input[i2] + input[i3] + input[i4] + input[i5];
                            counter++;
                            if (counter == n)
                            {
                                isFind = true;
                                Console.WriteLine(result);
                            }
                        }
                    }
                }
            }
        }
        if (!isFind)
        {
            Console.WriteLine("No");
        }

    }
}
