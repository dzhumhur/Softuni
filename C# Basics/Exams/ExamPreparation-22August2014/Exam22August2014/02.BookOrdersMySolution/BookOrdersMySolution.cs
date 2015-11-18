using System;
using System.Collections.Generic;
using System.Linq;
class BookOrdersMySolution
{
    static void Main()
    {
        int booksOrder = int.Parse(Console.ReadLine());
        int bookSum = 0;
        int currentSum = 0;
        double discount = 0;
        double price = 0;

        for (int i = 0; i < booksOrder; i++)
        {
            int packets = int.Parse(Console.ReadLine());
            int books = int.Parse(Console.ReadLine());
            double currentPrice  = double.Parse(Console.ReadLine());

            if (packets < 10)
            {
                currentSum = packets * books;
                discount = currentSum * currentPrice;
            }
            else if (packets >= 10 && packets <= 19)
            {
                currentSum = packets  * books;
                discount = currentSum * (currentPrice * 0.95);
            }
            else if (packets >= 20 && packets <= 29)
            {
                currentSum = packets  * books;
                discount = currentSum * (currentPrice * 0.94);
            }
            else if (packets >= 30 && packets <= 39)
            {
                currentSum = packets  * books;
                discount = currentSum * (currentPrice * 0.93);
            }
            else if (packets >= 40 && packets <= 49)
            {
                currentSum = packets  * books;
                discount = currentSum * (currentPrice * 0.92);
            }
            else if (packets >= 50 && packets <= 59)
            {
                currentSum = packets  * books;
                discount = currentSum * (currentPrice * 0.91);
            }
            else if (packets >= 60 && packets <= 69)
            {
                currentSum = packets * books;
                discount = currentSum * (currentPrice * 0.90);
            }
            else if (packets >= 70 && packets <= 79)
            {
                currentSum = packets * books;
                discount = currentSum * (currentPrice * 0.89);
            }
            else if (packets >= 80 && packets <= 89)
            {
                currentSum = packets * books;
                discount = currentSum * (currentPrice * 0.88);
            }
            else if (packets >= 90 && packets <= 99)
            {
                currentSum = packets * books;
                discount = currentSum * (currentPrice * 0.87);
            }
            else if (packets >= 100 && packets <= 109)
            {
                currentSum = packets * books;
                discount = currentSum * (currentPrice * 0.86);
            }
            else
            {
                currentSum = packets * books;
                discount = currentSum * (currentPrice * 0.85);
            }

            bookSum += currentSum;
            price += discount;
        }
        Console.WriteLine(bookSum);
        Console.WriteLine("{0:f2}",price);
    }
}

