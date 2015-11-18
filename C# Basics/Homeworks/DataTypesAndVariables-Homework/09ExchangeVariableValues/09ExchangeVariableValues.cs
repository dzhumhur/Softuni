using System;

class ExchangeVariableValues
{
    static void Main()
    {
        byte a = 5;
        byte b = 10;
        Console.WriteLine("a = {0}\nb = {1}", a, b);
        byte c = a;
        a = b;
        b = c;
        Console.WriteLine("\na = {0}\nb = {1}", a, b);
    }
}