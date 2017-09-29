using System;

class Time15Minutes
{
    static void Main()
    {

        int hour = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        DateTime time = new DateTime();
        time = time.AddHours(hour);
        time = time.AddMinutes(minutes + 15);

        Console.WriteLine(time.ToString("H:mm"));

    }
}
