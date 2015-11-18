using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
class Problem2
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arrayOfStrings = input.Split(' ');

        string secondInput = arrayOfStrings[0];
        string[] originalYear = secondInput.Split('.');

        string name = arrayOfStrings[1];
        long letSum = 0;

        long day = (long.Parse(originalYear[0]));
        long mounth = (long.Parse(originalYear[1]));
        long year = (long.Parse(originalYear[2]));
        long currentDateTimeSum = day * mounth * year;


        long dateTimeSum = (long)(Math.Pow(currentDateTimeSum, 2));

        if (name != "")
        {
            for (int i = 0; i < name.Length; i++)
            {

                if (name[i] >= 97 && name[i] <= 122)
                {
                    letSum += name[i] - 'a' + 1;
                }

                else if (name[i] >= 48 && name[i] <= 57)
                {
                    int currentDigit = int.Parse("" + name[i]);
                    letSum += currentDigit;
                }
                else
                {
                    letSum += ((name[i] + 32) - 'a' + 1) * 2;
                }
            }

            long result = dateTimeSum + letSum;
            string resultAsString = Convert.ToString(result);
            long resultsSum = 0;
            for (int i = 0, j = 10; i < resultAsString.Length; i++)
            {

                resultsSum += (long)(result % j);
                result = result / 10;
            }
            long firstNumberOfResult = 0;
            long secondNumberOfResult = 0;

            if (resultsSum < 13)
            {
                Console.WriteLine(resultsSum);
            }
            else
            {
                firstNumberOfResult = resultsSum / 10;
                secondNumberOfResult = resultsSum % 10;
                if (firstNumberOfResult + secondNumberOfResult <= 13)
                {
                    Console.WriteLine(firstNumberOfResult + secondNumberOfResult);
                }
                else
                {
                    while (resultsSum <= 13)
                    {
                        firstNumberOfResult = resultsSum / 10;
                        secondNumberOfResult = resultsSum % 10;
                        resultsSum = firstNumberOfResult + secondNumberOfResult;
                    }
                    Console.WriteLine(resultsSum);
                }
            }
        }

        else
        {
            long result = dateTimeSum;
            string resultAsString = Convert.ToString(result);
            long resultsSum = 0;
            for (int i = 0, j = 10; i < resultAsString.Length; i++)
            {

                resultsSum += (long)(result % j);
                result = result / 10;
            }
            long firstNumberOfResult = 0;
            long secondNumberOfResult = 0;

            if (resultsSum < 13)
            {
                Console.WriteLine(resultsSum);
            }
            else
            {
                firstNumberOfResult = resultsSum / 10;
                secondNumberOfResult = resultsSum % 10;
                if (firstNumberOfResult + secondNumberOfResult <= 13)
                {
                    Console.WriteLine(firstNumberOfResult + secondNumberOfResult);
                }
                else
                {
                    while (resultsSum <= 13)
                    {
                        firstNumberOfResult = resultsSum / 10;
                        secondNumberOfResult = resultsSum % 10;
                        resultsSum = firstNumberOfResult + secondNumberOfResult;
                    }
                    Console.WriteLine(resultsSum);
                }
            }
        }
        
    }
}

