using System;
using System.Text.RegularExpressions;

class TradeComissions
{
    static void Main()
    {

        string city = Console.ReadLine().ToLower();
        double sells = double.Parse(Console.ReadLine());

        bool containsCity = Regex.IsMatch("sofia varna plovdiv", @"\b" + city + @"\b");

        if (containsCity == false || sells < 0)
        {
            Console.WriteLine("error");
        }

        else
        {

            double[,] commision = new double[3, 4]
            {
                {  5,   7,  8,   12 },
                {4.5, 7.5, 10,   13 },
                {5.5,   8, 12, 14.5 }
            };

            int row = -1;
            int column = -1;


            switch (city)
            {
                case "sofia": row = 0; break;
                case "varna": row = 1; break;
                case "plovdiv": row = 2; break;
            }


            if (sells > 10000)
            {
                column = 3;
            }
            else if (sells > 1000 && sells <= 10000)
            {
                column = 2;
            }
            else if (sells > 500 && sells <= 1000)
            {
                column = 1;
            }
            else
            {
                column = 0;
            }


            Console.WriteLine("{0:0.00}", commision[row, column] * sells * 0.01);
        }
    }
}
