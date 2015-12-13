using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Interest_Calculator
{
    class ConsoleClient
    {
        const int months = 12;

        static void Main(string[] args)
        {
            var simpleInterest = new InterestCalculator(2500, 7.2m, 15, GetSimpleInterest);
            var compoundInterest = new InterestCalculator(500, 5.6m, 10, GetCompoundInterest);

            Console.WriteLine("Compound Interest = {0}", compoundInterest);
            Console.WriteLine("Simple Interest = {0}", simpleInterest);
            
        }

        static decimal GetSimpleInterest(decimal sum, decimal interest, int year)
        {
            interest /= 100;
            decimal result = sum  * (1 + (interest * year));

            return result;
        }

        static decimal GetCompoundInterest(decimal sum, decimal interest, int year)
        {
            interest /= 100;
            decimal result = sum * (decimal)Math.Pow(1 + (double)(interest / months), year * months);

            return result;
        }
    }
}
