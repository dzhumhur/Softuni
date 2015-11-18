﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digitSum = 0;
            bool found = false;

            string[] codes = { ".----", "..---", "...--", "....-", "....." };

            while (number > 0)
            {
                int digit = number % 10;
                digitSum += digit;
                number = number / 10;
            }

            for (int num1 = 1; num1 < 6; num1++)
            {
                for (int num2 = 1; num2 < 6; num2++)
                {
                    for (int num3 = 1; num3 < 6; num3++)
                    {
                        for (int num4 = 1; num4 < 6; num4++)
                        {
                            for (int num5 = 1; num5 < 6; num5++)
                            {
                                for (int num6 = 1; num6 < 6; num6++)
                                {
                                    int product = num1 * num2 * num3 * num4 * num5 * num6;

                                    if (product == digitSum)
                                    {
                                        found = true;
                                        Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|",
                                            codes[num1 - 1], codes[num2 - 1], codes[num3 - 1], codes[num4 - 1], codes[num5 - 1], codes[num6 - 1]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("No");
            }
        }
        
    }
}
