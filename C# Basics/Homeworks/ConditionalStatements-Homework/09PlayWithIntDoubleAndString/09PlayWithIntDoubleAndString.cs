using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.Write("Please choose a type:\n1 --> int\n2 --> double\n3 --> string: ");
        int choise = int.Parse(Console.ReadLine());
        switch (choise)
        {
            case 1:
                Console.Write("Please enter a integer: ");
                int intNum = int.Parse(Console.ReadLine());
                intNum++;
                Console.WriteLine(intNum);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleNum = double.Parse(Console.ReadLine());
                doubleNum++;
                Console.WriteLine(doubleNum);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str+"*");
                break;
        }
    }
}