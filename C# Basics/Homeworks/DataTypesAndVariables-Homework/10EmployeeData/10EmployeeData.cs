using System;

// First name
// Last name
// Age (0...100)
// Gender (m or f)
// Personal ID number (e.g. 8306112507)
// Unique employee number (27560000…27569999)


class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte age = 31;
        char gender = 'm';
        long personalIdNum = 8306112507;
        int UniqueEmplNum = 27569999;

        Console.WriteLine("Name - {0} {1}\nGender - {2}\nAge - {3}\nPernosal Id - {4}\nUnique employee number - {5}", firstName, lastName, gender, age, personalIdNum, UniqueEmplNum);
    }
}