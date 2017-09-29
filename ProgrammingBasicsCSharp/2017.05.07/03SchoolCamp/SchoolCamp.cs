using System;
using System.Collections.Generic;

class SchoolCamp
{
    static void Main()
    {
        string season = Console.ReadLine().ToLower();
        string group = Console.ReadLine().ToLower();
        int persons = int.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());


        string input = season + group;
        var price = new Dictionary<string, double>()
        {
            {"winterboys", 9.6 },
            {"wintergirls", 9.6 },
            {"wintermixed", 10.0 },
            {"springboys", 7.2 },
            {"springgirls", 7.2 },
            {"springmixed", 9.50 },
            {"summerboys", 15.0 },
            {"summergirls", 15.0 },
            {"summermixed", 20.0 }
        };

        var sport = new Dictionary<string, string>()
        {
            {"winterboys", "Judo" },
            {"wintergirls", "Gymnastics" },
            {"wintermixed", "Ski" },
            {"springboys", "Tennis" },
            {"springgirls", "Athletics" },
            {"springmixed", "Cycling" },
            {"summerboys", "Football" },
            {"summergirls", "Volleyball" },
            {"summermixed", "Swimming" }
        };

        double totalPrice = persons * nights * price[input];

        if (persons >= 50)
        {
            totalPrice = 0.5 * totalPrice;
        }
        else if (persons >= 20)
        {
            totalPrice = 0.85 * totalPrice;
        }
        else if (persons >= 10)
        {
            totalPrice = 0.95 * totalPrice;
        }

        Console.WriteLine("{0} {1:0.00} lv.", sport[input], totalPrice);

    }
}
