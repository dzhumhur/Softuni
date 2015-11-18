using System;

//(first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers 

class BankAccountData
{
    static void Main()
    {
        string firstName = "Genadii";
        string middleName = "Efstatiev";
        string lastName = "Haramapiev";
        decimal amountMoney = 12345.67m;
        string bankName = "BNB";
        string iBAN = "BG80BNBG96611020345678";
        long creditCard1 = 1234567890123451;
        long creditCard2 = 2345678901234567;
        long creditCard3 = 3456789012345678;

        Console.WriteLine("BANK ACOUNT");
        Console.WriteLine("Holder name: {0} {1} {2};", firstName, middleName, lastName);
        Console.WriteLine("Available money: {0};", amountMoney);
        Console.WriteLine("Bank name: {0};", bankName);
        Console.WriteLine("IBAN: {0};", iBAN);
        Console.WriteLine("First credit card number: - {0};", creditCard1);
        Console.WriteLine("Second credit card number: - {0};", creditCard2);
        Console.WriteLine("Third credit card number: - {0}.", creditCard3);
    }
}