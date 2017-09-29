using System;

class BonusScore
{
    static void Main()
    {

        int a = int.Parse(Console.ReadLine());
        double bonus = 0;

        if (a <= 100)
        {
            if (a % 2 == 0)
            {
                bonus = 5 + 1;
            }
            else if (a % 5 == 0)
            {
                bonus = 5 + 2;
            }
            else
                bonus = 5;
        }

        else if (100 < a && a <= 1000)
        {
            if (a % 2 == 0)
            {
                bonus = a * 0.2 + 1;
            }
            else if (a % 5 == 0)
            {
                bonus = a * 0.2 + 2;
            }
            else
                bonus = a * 0.2;

        }
        else if (a > 1000)
        {
            if (a % 2 == 0)
            {
                bonus = a * 0.1 + 1;
            }
            else if (a % 5 == 0)
            {
                bonus = a * 0.1 + 2;
            }
            else
                bonus = a * 0.1;
        }
        Console.WriteLine(bonus);
        Console.WriteLine(a + bonus);


    }
}
