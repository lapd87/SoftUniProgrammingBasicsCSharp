using System;

class AlcoholMarket
{
    static void Main()
    {

        double whiskeyPrice = double.Parse(Console.ReadLine());
        double beer = double.Parse(Console.ReadLine());
        double wine = double.Parse(Console.ReadLine());
        double rakia = double.Parse(Console.ReadLine());
        double whiskey = double.Parse(Console.ReadLine());

        double rakiaPrice = whiskeyPrice * 0.5;
        double winePrice = rakiaPrice * 0.6;
        double beerPrice = rakiaPrice * 0.2;

        double total = whiskey * whiskeyPrice + beer * beerPrice + wine * winePrice + rakia * rakiaPrice;

        Console.WriteLine("{0:0.00}",total);




    }
}
