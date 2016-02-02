namespace _06.BittArray
{
    using System;

    class ConsoleClient
    {
        static void Main()
        {
            var bits = new BittArray(8);
            bits[0] = 1;
            bits[3] = 1;
            Console.WriteLine(bits);
        }
    }
}
