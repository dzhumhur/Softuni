using System;
using System.Collections.Generic;
using System.Linq;
class BookOrders
{
    static void Main()
    {
        int ordersCount = int.Parse(Console.ReadLine());
        int totalBooks = 0;
        double totalPrice = 1;
        double discount = 0;

        for (int i = 0; i < ordersCount; i++)
        {
            int numberOfPackets = int.Parse(Console.ReadLine());
            int booksPerPacket = int.Parse(Console.ReadLine());
            double bookPrice = double.Parse(Console.ReadLine());
            totalBooks += numberOfPackets * booksPerPacket;

            if (numberOfPackets > 10 && numberOfPackets >= 109)
            {
                discount = (100 - (numberOfPackets / 10 + 4)) / 100.0;
            }
            else if (numberOfPackets >= 10 && numberOfPackets <=109)
            {
                discount = (100 - 15) / 100.0;
            }
            totalPrice += numberOfPackets * booksPerPacket * bookPrice * discount;
        }
        Console.WriteLine(totalBooks);
        Console.WriteLine("{0:f2}", discount);
    }
}

