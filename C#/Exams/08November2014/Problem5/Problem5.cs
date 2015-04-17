using System;
using System.Collections.Generic;
using System.Linq;
class Problem5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string nAsString = Convert.ToString(n, 2);
        for (int i = 0; i < 4; i++)
        {
            int firsNumber = int.Parse(Console.ReadLine());
            string firsInput = Console.ReadLine();

            if (firsInput == "flip")
            {
                int mask = firsNumber;
                n = n ^ mask;
            }
            else if (firsInput == "insert")
            {
                nAsString = nAsString.PadLeft(firsNumber, '0');
            }
            else if (firsInput == "remove")
            {
                
                    
            }
            else if (firsInput == "skip")
            {
                
            }
        }
        string quit = Console.ReadLine();
        Console.WriteLine(n);


    }
}

