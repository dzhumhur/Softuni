using System;

class AgeNowAndAfterTenYears
{
    static void Main()
    {
        DateTime currendDate = DateTime.Now;
        Console.Write("Enter your birthday (dd.mm.yyyy): ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        
        TimeSpan ageNow = currendDate - birthday;
        double age = ageNow.TotalDays / 365.25;

        Console.WriteLine("Your age now is: " + (int)age);
        Console.WriteLine("Your age after 10 years is: " + ((int)age + 10));
    }
}
