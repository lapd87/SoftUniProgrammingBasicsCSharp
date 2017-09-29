using System;

class Volleyball
{
    static void Main()
    {
        string yearType = Console.ReadLine().ToLower();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        double playedGames = 0;
        int totalWeekends = 48;
        int weekendsSofia = totalWeekends - h;
        playedGames += weekendsSofia * 3 / 4.0;
        playedGames += p * 2 / 3.0;
        playedGames += h;

        if (yearType == "leap")
        {
            playedGames *= 1.15;
        }
        Console.WriteLine(Math.Floor(playedGames));
    }
}
