namespace Bank_of_Kurtovo_Konare.Bank.Accounts
{
    using Bank_of_Kurtovo_Konare.Bank.Customers;
    using System;

    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, double interestRate, int duration) : base(customer, balance, interestRate, duration)
        {
        }

        public override decimal CalcInterest()
        {
            decimal balance = this.Balance;
            int duration = this.Duration;

            if (this.Customer.GetType().Name.Equals("Individual"))
            {
                if (duration - 6 > 0)
                {
                    balance = balance * (1 + (decimal)((this.InterestRate / 100) * duration - 6));
                }
            }
            else if (this.Customer.GetType().Name.Equals("Company"))
            {
                if (duration - 12 <= 0)
                {
                    balance = balance * (1 + (decimal)(((this.InterestRate / 2) / 100) * 12 - duration));
                }
                else
                {
                    var durationWithoutFirst12 = duration - 12;
                    balance = balance * (1 + (decimal)(((this.InterestRate / 2) / 100) * 12 - duration));
                    balance += balance * (1 + (decimal)((this.InterestRate / 100) * durationWithoutFirst12));
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
