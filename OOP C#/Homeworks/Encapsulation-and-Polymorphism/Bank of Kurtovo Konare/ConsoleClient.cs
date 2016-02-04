namespace Bank_of_Kurtovo_Konare
{
    using Bank.Accounts;
    using Bank.Customers;
    using System;

    class ConsoleClient
    {
        static void Main()
        {
            var deposit = new Deposit(new Individual("Nakov", 5), 10000, 1.5, 10);
            Console.WriteLine(deposit.CalcInterest());
            deposit.WithdrawMoney(5000);
            Console.WriteLine(deposit.Balance);
        }
    }
}
