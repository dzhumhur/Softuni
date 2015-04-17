using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter Your weight: ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Your weight on the Moon is : {0}", weight * 0.17);
    }
}