using System;

class Cups
{
    static void Main()
    {
        int cupsNeeded = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int workDays = int.Parse(Console.ReadLine());

        int cupsMade = workers * 8 * workDays / 5;

        if (cupsMade<cupsNeeded)
        {
            Console.WriteLine("Losses: {0:0.00}", (cupsNeeded-cupsMade)*4.20);
        }
        else
        {
            Console.WriteLine("{0:0.00} extra money", (cupsMade- cupsNeeded) * 4.20);
        }
    }
}
