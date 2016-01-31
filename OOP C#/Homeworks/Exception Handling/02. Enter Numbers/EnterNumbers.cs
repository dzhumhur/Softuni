namespace _02.Enter_Numbers
{
    using System;

    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                ReadNumber(1, 100);
            }
        }

        static void ReadNumber(int start, int end)
        {
            try
            {
                var number = int.Parse(Console.ReadLine());
                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("The number should be positive integer number");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("The number should be in range [1...100]");
            }
        }
    }
}
