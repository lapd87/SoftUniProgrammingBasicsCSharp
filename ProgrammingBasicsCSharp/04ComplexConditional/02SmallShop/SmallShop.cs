using System;
using System.Collections.Generic;

class SmallShop
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();
        string city = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());

        string cityProduct = city + product;
        var choosing = new Dictionary<string, double>()
        {
            { "sofiacoffee",0.50},
            { "sofiawater",0.80},
            { "sofiabeer",1.20},
            { "sofiasweets",1.45},
            { "sofiapeanuts",1.60},
            { "plovdivcoffee",0.40},
            { "plovdivwater",0.70},
            { "plovdivbeer",1.15},
            { "plovdivsweets",1.30},
            { "plovdivpeanuts",1.50},
            { "varnacoffee",0.45},
            { "varnawater",0.70},
            { "varnabeer",1.10},
            { "varnasweets",1.35},
            { "varnapeanuts",1.55},
        };


        Console.WriteLine(choosing[cityProduct] * quantity);
    }
}
