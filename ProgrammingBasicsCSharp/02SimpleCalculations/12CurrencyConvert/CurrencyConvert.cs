using System;
using System.Collections.Generic;

class CurrencyConvert
{
    static void Main()
    {
        double amount = double.Parse(Console.ReadLine());
        string inputCurrency = Console.ReadLine();
        string outputCurrency = Console.ReadLine();
        Dictionary<string, double> currency = new Dictionary<string, double>()
        {
            { "BGN", 1}, { "USD",1.79549 }, { "EUR",1.95583},{ "GBP",2.53405}
        };
        double result = amount * currency[inputCurrency] / currency[outputCurrency];
        Console.WriteLine(Math.Round(result, 2) + " " + outputCurrency);
    }
}

