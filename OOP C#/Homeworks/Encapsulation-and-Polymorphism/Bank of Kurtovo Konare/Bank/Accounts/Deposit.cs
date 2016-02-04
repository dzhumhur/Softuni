using System;
using Bank_of_Kurtovo_Konare.Bank.Customers;

namespace Bank_of_Kurtovo_Konare.Bank.Accounts
{
    public class Deposit : Account
    {
        public Deposit(Customer customer, decimal balance, double interestRate, int duration) 
                         : base(customer, balance, interestRate, duration)
        {
        }

        public override decimal CalcInterest()
        {
            decimal balance = this.Balance;
            double interestRate = this.InterestRate / 100;

            if (balance > 1000)
            {
                balance = balance * (1 + (decimal)(interestRate * this.Duration));
            }

            return balance;
        }
    }
}
