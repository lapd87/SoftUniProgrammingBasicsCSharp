using System;

class Task04
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int dancers = int.Parse(Console.ReadLine());

        double totalEnergy = 100.0 * days * dancers;
        double usedEnergy = 0.0;

        for (int i = 1; i <= days; i++)
        {
            int hours = int.Parse(Console.ReadLine());

            if (i % 2 == 0 && hours % 2 == 0)
            {
                usedEnergy += 68 * dancers;
            }
            else if (hours % 2 == 0)
            {
                usedEnergy += 49 * dancers;
            }
            else if (i % 2 == 0)
            {
                usedEnergy += 65 * dancers;
            }
            else
            {
                usedEnergy += 30 * dancers;
            }
        }

        double remainingEnergy = totalEnergy - usedEnergy;
        double averageEnergy = remainingEnergy / dancers / days * 1.0;

        if (averageEnergy > 50)
        {
            Console.WriteLine("They feel good! Energy left: {0:0.00}", averageEnergy);
        }
        else
        {
            Console.WriteLine("They are wasted! Energy left: {0:0.00}", averageEnergy);
        }
    }
}
