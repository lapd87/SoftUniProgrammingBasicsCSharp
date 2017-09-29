using System;

class NumberToText
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());

        string[] toNineteen = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

        string[] toNinety = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };


        if (number < 0 || number > 100)
        {
            Console.WriteLine("invalid number");
        }
        else if (number >= 0 && number < 20)
        {
            Console.WriteLine(toNineteen[number]);
        }
        else if (number >= 20 && number < 100)
        {
            int digits = number % 10;
            int decimals = (number - digits) / 10;

            if (digits==0)
            {
                Console.WriteLine(toNinety[decimals - 2]);
            }
            else
            {
                Console.WriteLine(toNinety[decimals - 2] + " " + toNineteen[digits]);
            }
        }
        else
            Console.WriteLine("one hundred");
    }
}
