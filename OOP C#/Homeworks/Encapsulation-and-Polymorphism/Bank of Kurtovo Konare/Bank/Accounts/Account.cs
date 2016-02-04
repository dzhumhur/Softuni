namespace Bank_of_Kurtovo_Konare.Bank.Accounts
{
    using System;
    using Customers;

    public abstract class Account
    {
        private decimal balance;
        private double interestRate;
        private int duration;

        protected Account(Customer customer, decimal balance, double interestRate, int duration)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Duration = duration;
        }

        public Customer Customer { get; set; }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative");
                }

                this.balance = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Interest cannot be negative");
                }

                this.interestRate = value;
            }
        }

        public int Duration { get; set; }

        public virtual void DepositMoney(decimal value)
        {
            this.Balance += value;
        }

        public virtual void WithdrawMoney(decimal withdrawSum)
        {
            if (this.Balance < withdrawSum)
            {
                throw new ArgumentException("Not enough money int the balance");
            }

            this.Balance -= withdrawSum;
        }

        public  virtual decimal CalcInterest()
        {
            double interestPecentage = this.InterestRate / 100;
            decimal balance = this.Balance * (decimal)(1 + (interestPecentage * this.duration));

            return balance;
        }
    }
}
