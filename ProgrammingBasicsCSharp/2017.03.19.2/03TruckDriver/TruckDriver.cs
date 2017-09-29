using System;

class TruckDriver
{
    static void Main()
    {
        string season = Console.ReadLine().ToLower();
        double kmMonthly = double.Parse(Console.ReadLine());

        double[,] sallary = new double[3, 3]
           { { 0.75, 0.90,  1.05 },
             { 0.95, 1.10,  1.25 },
             { 1.45, 1.45,  1.45 }
           };

        int row = -1;
        int col = -1;

        switch (season)
        {
            case "spring":
            case "autumn": col = 0; break;
            case "summer": col = 1; break;
            case "winter": col = 2; break;
        }

        if (kmMonthly <= 5000) row = 0;
        else if (kmMonthly <= 10000) row = 1;
        else if (kmMonthly <= 20000) row = 2;

        Console.WriteLine("{0:0.00}", kmMonthly * sallary[row, col] * 4 * 0.9);
    }
}
