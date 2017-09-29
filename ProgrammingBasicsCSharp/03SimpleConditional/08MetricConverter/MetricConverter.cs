using System;
using System.Collections.Generic;

class MetricConverter
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        string input = Console.ReadLine().ToLower();
        string output = Console.ReadLine().ToLower();

        var convert = new Dictionary<string, double>()
        {
            {"mm", 1000 },
            {"cm", 100 },
            {"mi", 0.000621371192},
            {"in", 39.3700787},
            {"km", 0.001},
            {"ft", 3.2808399},
            {"yd", 1.0936133},
            {"m", 1}
        };

        var result = number / convert[input] * convert[output];


        Console.WriteLine("{0}  {1}", result, output);

    }
}
