using System;

class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine(nullInt + "\n" + nullDouble);
        
        nullInt = 1;
        nullDouble = 1;
        Console.WriteLine(nullInt + "\n" + nullDouble);
    }
}