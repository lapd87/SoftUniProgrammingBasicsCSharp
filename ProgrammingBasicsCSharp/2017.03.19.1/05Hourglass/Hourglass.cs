using System;

class Hourglass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', 2 * n + 1));
        Console.WriteLine(".*" + new string(' ', 2 * n - 3) + "*.");

        for (int row = 2; row <= n - 1; row++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', row), new string('@', 2 * n - 1 - 2 * row));
        }

        Console.WriteLine("{0}*{0}", new string('.', n));

        for (int row = 0; row < n - 2; row++)
        {
            Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', n - 1 - row), new string(' ', row));
        }

        Console.WriteLine(".*{0}*.", new string('@', 2 * n - 3));
        Console.WriteLine(new string('*', 2 * n + 1));
    }
}
