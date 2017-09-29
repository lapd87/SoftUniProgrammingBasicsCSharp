using System;

class FruitCocktail
{
    static void Main()
    {
        string fruit = Console.ReadLine();
        string size = Console.ReadLine();
        int drinks = int.Parse(Console.ReadLine());

        string fruitSize = fruit + size;
        double pricePerDrink = 0;

        switch (fruitSize)
        {
            case "Watermelonsmall": pricePerDrink = 2 * 56; break;
            case "Watermelonbig": pricePerDrink = 5 * 28.7; break;
            case "Mangosmall": pricePerDrink = 2 * 36.66; break;
            case "Mangobig": pricePerDrink = 5 * 19.6; break;
            case "Pineapplesmall": pricePerDrink = 2 * 42.1; break;
            case "Pineapplebig": pricePerDrink = 5 * 24.8; break;
            case "Raspberrysmall": pricePerDrink = 2 * 20; break;
            case "Raspberrybig": pricePerDrink = 5 * 15.2; break;
            default:
                break;
        }

        double check = pricePerDrink * drinks;

        if (check > 1000)
        {
            check *= 0.5;
        }
        else if (check >= 400)
        {
            check *= 0.85;
        }

        Console.Write("{0:0.00} lv.", check);
    }
}
