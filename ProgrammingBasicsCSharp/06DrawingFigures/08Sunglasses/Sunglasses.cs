using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));

        for (int row = 1; row <= n - 2; row++)
        {
            if (row == Math.Ceiling((n-2) / 2.0))
            {
                Console.WriteLine('*' + new string('/', 2 * n - 2) + '*' + new string('|', n) + '*' + new string('/', 2 * n - 2) + '*');
            }
            else
            {
                Console.WriteLine('*' + new string('/', 2 * n - 2) + '*' + new string(' ', n) + '*' + new string('/', 2 * n - 2) + '*');
            }
        }
        Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
    }
}