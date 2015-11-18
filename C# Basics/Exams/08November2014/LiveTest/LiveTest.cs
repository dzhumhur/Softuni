using System;
using System.Collections.Generic;
using System.Linq;
class LiveTest
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('.', ' ');
        int day = int.Parse(input[0]);
        int mount = int.Parse(input[1]);
        int year = int.Parse(input[2]);
        string name = input[3];
        ulong dateProduct = (ulong)(day * mount * year);
        int letterSum = 0;

        if (mount % 2 != 0)
        {
            dateProduct *= dateProduct;
        }

        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] >= 97 && name[i] <= 122)
            {
                letterSum += name[i] - 'a' + 1;
            }
            else if (true)
            {
                
            }
        }


    }
}

