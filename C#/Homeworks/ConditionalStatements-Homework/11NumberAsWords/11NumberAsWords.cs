using System;

class NumbersToWords
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int firstDigit;
        int secondDigit;
        int thirtDigit;


        if (number >= 0 && number < 10)
        {
            Digits(number);
        }
        else if (number >= 10 && number < 20)
        {
            Specials(number);
        }
        else if (number >= 20 && number < 100)
        {
            firstDigit = number / 10;
            secondDigit = number % 10;
            if (secondDigit == 0)
            {
                Tens(firstDigit);
            }
            else
            {
                Tens(firstDigit);
                Digits(secondDigit);
            }
        }
        else if (number >= 100 && number < 1000)
        {
            firstDigit = number / 100;
            secondDigit = (number / 10) % 10;
            thirtDigit = number % 10;
            if (thirtDigit == 0 && secondDigit == 0)
            {
                Hundreds(firstDigit);
            }
            else if (thirtDigit == 0 && secondDigit != 0)
            {
                Hundreds(firstDigit);
                Console.Write("and ");
                Tens(secondDigit);
            }
            else if (secondDigit == 0 && thirtDigit != 0)
            {
                Hundreds(firstDigit);
                Console.Write("and ");
                Digits(thirtDigit);
            }
            else if (secondDigit != 0 && thirtDigit != 0)
            {
                if (number % 100 >= 11 && number % 100 <= 19)
                {
                    Hundreds(firstDigit);
                    Console.Write("and ");
                    Specials(number % 100);
                }
                else
                {
                    Hundreds(firstDigit);
                    Console.Write("and ");
                    Tens(secondDigit);
                    Digits(thirtDigit);
                }
            }
        }
        Console.WriteLine();
    }

    private static void Hundreds(int number)
    {
        switch (number)
        {
            case 1:
                Console.Write("One Hundred ");
                break;
            case 2:
                Console.Write("Two Hunderd ");
                break;
            case 3:
                Console.Write("Three Hundred ");
                break;
            case 4:
                Console.Write("Four Hundred ");
                break;
            case 5:
                Console.Write("Five Hundred ");
                break;
            case 6:
                Console.Write("Six Hundred ");
                break;
            case 7:
                Console.Write("Seven Hundred ");
                break;
            case 8:
                Console.Write("Eight Hundred ");
                break;
            case 9:
                Console.Write("Nine Hundred ");
                break;
        }
    }

    public static void Tens(int number)
    {
        switch (number)
        {
            case 2:
                Console.Write("Twenty ");
                break;
            case 3:
                Console.Write("Thirty ");
                break;
            case 4:
                Console.Write("Forty ");
                break;
            case 5:
                Console.Write("Fifty ");
                break;
            case 6:
                Console.Write("Sixty ");
                break;
            case 7:
                Console.Write("Seventy ");
                break;
            case 8:
                Console.Write("Eighty ");
                break;
            case 9:
                Console.Write("Ninety ");
                break;
        }
    }

    public static void Digits(int number)
    {
        switch (number)
        {
            case 0:
                Console.Write("Zero ");
                break;
            case 1:
                Console.Write("One ");
                break;
            case 2:
                Console.Write("Two ");
                break;
            case 3:
                Console.Write("Three ");
                break;
            case 4:
                Console.Write("Four ");
                break;
            case 5:
                Console.Write("Five ");
                break;
            case 6:
                Console.Write("Six ");
                break;
            case 7:
                Console.Write("Seven ");
                break;
            case 8:
                Console.Write("Eight ");
                break;
            case 9:
                Console.Write("Nine ");
                break;
        }
    }

    public static void Specials(int number)
    {
        switch (number)
        {
            case 10:
                Console.Write("Ten ");
                break;
            case 11:
                Console.Write("Eleven ");
                break;
            case 12:
                Console.Write("Twelve ");
                break;
            case 13:
                Console.Write("Thirteen ");
                break;
            case 14:
                Console.Write("Fourteen ");
                break;
            case 15:
                Console.Write("Fifteen ");
                break;
            case 16:
                Console.Write("Sixteen ");
                break;
            case 17:
                Console.Write("Seventeen ");
                break;
            case 18:
                Console.Write("Eighteen ");
                break;
            case 19:
                Console.Write("Nineteen ");
                break;
        }
    }

}