using System;

class GreatestCommonDivisior
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        int oldMin = min;

        while (min != 0)
        {
            oldMin = min;
            min = max % min;
            max = oldMin;
        }

        Console.WriteLine(oldMin);
    }
}
