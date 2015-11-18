using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 1; i <= numbers.Length; i++)
        {
            if (i % 2 != 0)
            {
                oddProduct *= int.Parse(numbers[i-1]);
            }
            else
            {
                evenProduct *= int.Parse(numbers[i-1]);
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}