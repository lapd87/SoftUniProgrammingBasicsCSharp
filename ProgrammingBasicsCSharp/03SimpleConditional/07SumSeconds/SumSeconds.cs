using System;

class SumSeconds
{
    static void Main()
    {

        int time1 = int.Parse(Console.ReadLine());
        int time2 = int.Parse(Console.ReadLine());
        int time3 = int.Parse(Console.ReadLine());
        int totalTime = time1 + time2 + time3;
        int seconds = totalTime % 60;
        int minutes = (totalTime - seconds) / 60;

        Console.WriteLine(minutes + ":" + string.Format("{0:00}", seconds));

    }
}
