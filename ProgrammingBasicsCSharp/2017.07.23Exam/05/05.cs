using System;

class Task05
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++)
        {
            string dots = new string('.', n + i);
            string sharp = new string('#', 3 * n - 2 * i);

            Console.WriteLine(dots + sharp + dots);
        }

        for (int i = 0; i < n / 2 + 1; i++)
        {
            string dots = new string('.', n / 2 * 3 + i);
            string sharpDots = new string('.', 2 * n - 2 - 2 * i);
            Console.WriteLine(dots + "#" + sharpDots + "#" + dots);
        }

        Console.WriteLine(new string('.', 2 * n) + new string('#', n) + new string('.', 2 * n));

        string endDots = new string('.', n * 2 - 2);
        string endSharp = new string('#', n + 4);

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(endDots + endSharp + endDots);
        };

        Console.WriteLine(new string('.', (5 * n - 10) / 2) + "D^A^N^C^E^" + new string('.', (5 * n - 10) / 2));

        for (int i = 0; i <= n / 2; i++)
        {
            Console.WriteLine(endDots + endSharp + endDots);
        };
    }
}
