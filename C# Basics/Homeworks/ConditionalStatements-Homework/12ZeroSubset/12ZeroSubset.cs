using System;

class ZeroSubset
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int zeroSubset = 0;
        if (a == 0 && b == 0 && c == 0 && d == 0 && e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
        }
        else if (a != 0 || b != 0 || c != 0 || d != 0 || e != 0)
        {
            if (a + b == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, b);
                zeroSubset++;
            }
            if (a + c == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, c);
                zeroSubset++;
            }
            if (a + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, d);
                zeroSubset++;
            }
            if (a + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, e);
                zeroSubset++;
            }
            if (b + c == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, c);
                zeroSubset++;
            }
            if (b + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, d);
                zeroSubset++;
            }
            if (b + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, e);
                zeroSubset++;
            }
            if (c + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, d);
                zeroSubset++;
            }
            if (c + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, e);
                zeroSubset++;
            }
            if (d + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", d, e);
                zeroSubset++;
            }
            if (a + b + c == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
                zeroSubset++;
            }
            if (a + b + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
                zeroSubset++;
            }
            if (a + b + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
                zeroSubset++;
            }
            if (a + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
                zeroSubset++;
            }
            if (a + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
                zeroSubset++;
            }
            if (a + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
                zeroSubset++;
            }
            if (b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
                zeroSubset++;
            }
            if (b + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
                zeroSubset++;
            }
            if (b + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
                zeroSubset++;
            }
            if (c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
                zeroSubset++;
            }
            if (a + b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
                zeroSubset++;
            }
            if (a + b + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
                zeroSubset++;
            }
            if (a + b + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
                zeroSubset++;
            }
            if (a + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
                zeroSubset++;
            }
            if (b + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
                zeroSubset++;
            }

            if (a + b + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4}= 0", a, b, c, d, e);
                zeroSubset++;
            }

            if (zeroSubset == 0)
            {
                Console.WriteLine("no zero subset");
            }
        }  
    }
}