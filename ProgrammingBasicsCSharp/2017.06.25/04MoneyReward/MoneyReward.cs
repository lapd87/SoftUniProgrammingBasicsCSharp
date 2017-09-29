using System;

class MoneyReward
{
    static void Main()
    {
        int parts = int.Parse(Console.ReadLine());
        double moneyPerPoint = double.Parse(Console.ReadLine());

        double prize = 0;

        for (int i = 1; i <= parts; i++)
        {
            int points = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                prize += 2 * points;
            }
            else
            {
                prize += points;
            }
        }

        Console.WriteLine("The project prize was {0:0.00} lv.", prize * moneyPerPoint);
    }
}
