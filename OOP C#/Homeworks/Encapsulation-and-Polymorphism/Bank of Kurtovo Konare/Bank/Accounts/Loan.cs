using System;
using Bank_of_Kurtovo_Konare.Bank.Customers;

namespace Bank_of_Kurtovo_Konare.Bank.Accounts
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, double interestRate, int duration)
                       : base(customer, balance, interestRate, duration)
        {
        }

        public override decimal CalcInterest()
        {
            decimal balance = this.Balance;
            int duration = this.Duration;

            if (this.Customer.GetType().Name.Equals("Individual"))
            {
                if (duration - 3 > 0)
                {
                    balance = balance * (1 + (decimal)((this.InterestRate / 100) * duration - 3));
                }
            }
            else if (this.Customer.GetType().Name.Equals("Company"))
            {
                if (duration - 2 > 0)
                {
                    balance = balance * (1 + (decimal)((this.InterestRate / 100) * duration - 2));
                }
            }

            return balance;
        }

        public override void WithdrawMoney(decimal withdrawSum)
        {
            throw new InvalidOperationException("Cannot withdraw");
        }
    }
}
