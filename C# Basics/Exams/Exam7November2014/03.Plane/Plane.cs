using System;
using System.Collections.Generic;
using System.Linq;
class Plane
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstOutDots = (n * 3) / 2;
        int firstInnerDots = 1;
        int secondOutDots = n - 4;
        int secondInnerDots = n * 3 - (secondOutDots * 2 + 2);
        string top = new string('.', firstOutDots) + '*' + new string('.', firstOutDots);

        firstOutDots--;

        Console.WriteLine(top);

        for (int i = 0; i < n; i++)
        {
            if (firstOutDots >= n - 2)
            {
                Console.WriteLine(new string('.', firstOutDots) + '*' +
                                  new string('.', firstInnerDots) + '*' +
                                  new string('.', firstOutDots));
                firstOutDots--;
                firstInnerDots += 2;
            }
            else
            {
                Console.WriteLine(new string('.', secondOutDots) + '*' +
                                  new string('.', secondInnerDots) + '*' +
                                  new string('.', secondOutDots));
                secondOutDots -= 2;
                secondInnerDots += 4;
            }
        }


        int middleLeftRightDots = n - 4;
        int middleLeftRightDotsReversed = 1;

        for (int i = 0; i < n / 2; i++)
        {
            if (i == 0)
            {
                Console.WriteLine('*' + new string('.', n - 2) + '*' +
                          new string('.', n) + '*' + new string('.', n - 2) + '*');

            }
            else
            {
                Console.WriteLine('*' + new string('.', middleLeftRightDots) + '*' +
                                  new string('.', middleLeftRightDotsReversed) + '*' +
                                  new string('.', n) + '*' + new string('.', middleLeftRightDotsReversed) + '*' +
                                  new string('.', middleLeftRightDots) + '*');
                middleLeftRightDots -= 2;
                middleLeftRightDotsReversed += 2;
            }
        }

        int thirdOuterDots = n - 1;
        int thirdInnerDots = n;
        for (int i = 1; i <= n; i++)
        {
            if (i < n)
            {
                Console.WriteLine(new string('.', thirdOuterDots) + '*' +
                                  new string('.', thirdInnerDots) + '*' +
                                  new string('.', thirdOuterDots));
                thirdOuterDots--;
                thirdInnerDots += 2;
            }
            else
            {
                Console.WriteLine(new string('*', n * 3));
            }
        }
    }
}