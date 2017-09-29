using System;

class Vacation
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string location = "";
        string camp = "";
        double expenses = budget;

        if (season == "Summer")
        {
            location = "Alaska";
        }
        else if (season == "Winter")
        {
            location = "Morocco";
        }

        if (budget <= 1000)
        {
            camp = "Camp";
        }
        else if (budget <= 3000)
        {
            camp = "Hut";
        }
        else
        {
            camp = "Hotel";
        }
        switch (camp + location)
        {
            case "CampAlaska": expenses = 0.65 * budget; break;
            case "CampMorocco": expenses = 0.45 * budget; break;
            case "HutAlaska": expenses = 0.80 * budget; break;
            case "HutMorocco": expenses = 0.60 * budget; break;
            case "HotelAlaska":
            case "HotelMorocco": expenses = 0.90 * budget; break;

            default:
                break;
        }
        Console.WriteLine("{0} - {1} - {2:0.00}", location, camp, expenses);
    }
}
