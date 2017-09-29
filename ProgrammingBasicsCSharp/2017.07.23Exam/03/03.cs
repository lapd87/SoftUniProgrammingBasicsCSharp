using System;

class Task03
{
    static void Main()
    {
        int dancers = int.Parse(Console.ReadLine());
        double points = double.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();
        string location = Console.ReadLine().ToLower();

        string seasonLocation = season + location;

        decimal money = 0m;

        switch (seasonLocation)
        {
            case "summerbulgaria": money = (decimal)points * dancers * 0.95m; break;
            case "winterbulgaria": money = (decimal)points * dancers * 0.92m; break;
            case "summerabroad": money = (decimal)points * dancers * 1.5m * 0.9m; break;
            case "winterabroad": money = (decimal)points * dancers * 1.5m * 0.85m; break;
        }

        Console.WriteLine("Charity - {0:0.00}", money * 0.75m);
        Console.WriteLine("Money per dancer - {0:0.00}", money * 0.25m / dancers);

    }
}
