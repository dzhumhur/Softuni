using System;

class InsideTheBuilding
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < 5; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool isInside = true;

            if (y < 0)
            {
                isInside = false;
            }
            else if (y <= n)
            {
                if (x > (n * 3) || x < 0)
                {
                    isInside = false;
                }

            }

            if (y <= (n * 4) && y > n)
            {
                if (x < n || x > (n * 2))
                {
                    isInside = false;
                }
            }
            if (y > (n * 4))
            {
                isInside = false;
            }
            if (isInside)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}