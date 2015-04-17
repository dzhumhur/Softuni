using System;
using System.Collections.Generic;
using System.Linq;
class CarMySolution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = n - 1;
        int innerDots = n;
        string top = new string('.', n) + new string('*', n) + new string('.', n);

        for (int i = 1; i <= n/2 + 1; i++)
        {
            if (i == 1)
            {
                Console.WriteLine(top);
            }
            else if (i < n/2 + 1)
            {
                Console.WriteLine(new string('.', outerDots) + '*' + new string('.', innerDots) + '*' + new string('.', outerDots));
                outerDots--;
                innerDots += 2;
            }
            else
            {
                Console.WriteLine(new string('*', outerDots) + '*' + new string('.', innerDots) + '*' + new string('*', outerDots));
            }
        }
        for (int i = 1; i <= n/2 - 1; i++)
	    {
			 if (i < n/2 - 1 )
	         {   
                Console.WriteLine('*' + new string('.',n*3 - 2) + '*');
	         }
             else
	         {
                 Console.WriteLine(new string('*',n*3));
	         }
        }
        for (int i = 1; i <= n/2 -1; i++)
        {
            if (i < n/2 - 1)
            {
                Console.WriteLine(new string('.', n / 2) + '*' + new string('.',n/2 -1) + '*' + new string('.',n-2)+
                                  '*' + new string('.',n/2 -1) + '*' + new string('.', n / 2));
            }
            else
            {
                Console.WriteLine(new string('.', n / 2) + '*' + new string('*', n / 2 - 1) + '*' + new string('.', n - 2) +
                                  '*' + new string('*', n / 2 - 1) + '*' + new string('.', n / 2));
            }
        }
    }
}

