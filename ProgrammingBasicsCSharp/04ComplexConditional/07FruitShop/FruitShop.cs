using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class FruitShop
{
    static void Main()
    {

        string fruit = Console.ReadLine().ToLower();
        string day = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());

        double sum = 0.0;

        //var arrayFruit = new[] { "banana", "apple", "orange", "grapefruit", "kiwi", "pineapple", "grapes" };
        //var arrayDay = new[] { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };

        bool containsFruit = Regex.IsMatch("banana apple orange grapefruit kiwi pineapple grapes", @"\b" + fruit + @"\b");
        bool containsDay = Regex.IsMatch("monday tuesday wednesday thursday friday saturday sunday", @"\b" + day + @"\b");


        if (containsFruit && containsDay)
        {


            if (day == "saturday" || day == "sunday")
            {
                var price = new Dictionary<string, double>()
                {
                    {"banana",2.70},
                    {"apple",1.25},
                    {"orange",0.90},
                    {"grapefruit",1.60},
                    {"kiwi",3.00},
                    {"pineapple",5.60},
                    {"grapes",4.20}
                };
                sum = price[fruit] * quantity;
            }

            else
            {
                var price = new Dictionary<string, double>()
                {
                    {"banana",2.50},
                    {"apple",1.20},
                    {"orange",0.85},
                    {"grapefruit",1.45},
                    {"kiwi",2.70},
                    {"pineapple",5.50},
                    {"grapes",3.85}
                };
                sum = price[fruit] * quantity;
            }
            Console.WriteLine("{0:0.00}", sum);
        }

        else
        {
            Console.WriteLine("error");
        }

    }
}
