using System;

class ComparingFloats
{
    static void Main()
    
    {
        Console.WindowWidth = 128;

        Console.Write("Input first number: ");
        decimal firstNum = decimal.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        decimal secondNum = decimal.Parse(Console.ReadLine());
        
        Console.WriteLine("1st Number | 2nd Number | Equal (with precision eps=0,000001)");
        const decimal eps = 0.000001m;
        decimal diffOfNums = Math.Abs(firstNum - secondNum);
        Console.Write("{0}{1,13}", firstNum, secondNum);

        if (diffOfNums < eps)
        {
            Console.WriteLine("{0,10} - The difference {1} < eps", true, diffOfNums);
        }
        else
        {
            if (diffOfNums > eps)
            {
                Console.WriteLine("{0,10} - The difference of {1} is too big (> eps)", false, diffOfNums);
            }
            else
            {
                if (diffOfNums == eps)
                {
                    Console.WriteLine("{0,10} - Border case. The difference {1} == eps. We consider the numbers are different.", false, diffOfNums);
                }
            }
        }
    }
}