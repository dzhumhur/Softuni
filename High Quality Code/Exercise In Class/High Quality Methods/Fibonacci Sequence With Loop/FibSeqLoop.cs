using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence_With_Loop
{
    using System.Diagnostics;

    class FibSeqLoop
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            FibonacciIterative(10);
            sw.Stop();
            var iterative = sw.Elapsed;

            sw.Restart();
            FibonacciRecursively(0, 1, 1, 10);
            sw.Stop();
            var recursive = sw.Elapsed;

            Console.WriteLine("Iterative  = {0}", iterative);
            Console.WriteLine("Recursive  = {0}", recursive);
        }

        static void FibonacciIterative(int len)
        {
            BigInteger firstNumber = 0;
            BigInteger secondNumber = 1;
            BigInteger sum = 0;

            for (int i = 1; i < len; i++)
            {
                //Console.WriteLine(sum);
                firstNumber = secondNumber;
                secondNumber = sum;
                sum = firstNumber + secondNumber;
            }
        }

        static void FibonacciRecursively(BigInteger a, BigInteger b, int counter, int len)
        {
            //Console.WriteLine(a);
            if (counter < len)
            {
                counter++;
                FibonacciRecursively(b, a + b, counter, len);
            }
        }
    }
}
