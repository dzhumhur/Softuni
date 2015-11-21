namespace _02.Enter_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class EnterNumbers
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (!ReadNumber(1, 100))
                {
                    i--;
                }  
            }
        }

        static bool ReadNumber(int start, int end)
        {
            try
            {
                string input = Console.ReadLine();
                var number = int.Parse(input);

                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number should be in range [{0}...{1}]", start.ToString(), end.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("The number should be positive integer number");
            }

            return false;
        }
    }
}
