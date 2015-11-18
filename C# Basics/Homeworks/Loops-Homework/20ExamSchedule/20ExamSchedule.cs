using System;

class ExamSchedule
{
    static void Main()
    {
        int startHour = int.Parse(Console.ReadLine());
        int startMin = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int hourDuration = int.Parse(Console.ReadLine());
        int minDuration = int.Parse(Console.ReadLine());

        if (partOfDay == "PM")
        {
            startHour += 12;

            if (startHour == 24)
            {
                startHour = 0;
            }
        }

        DateTime startTime = new DateTime(2014, 10, 25, startHour, startMin, 0);
        DateTime endTime = startTime.AddHours(hourDuration).AddMinutes(minDuration);
        Console.WriteLine("{0:hh:mm:tt}", endTime);
    }
}