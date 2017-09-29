using System;

class Crown
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int width = 2 * n - 1;
        int height = n / 2 + 4;


        Console.WriteLine("@{0}@{0}@", new string(' ', n - 2));
        Console.WriteLine("**{0}*{0}**", new string(' ', n - 1 - 2));

        for (int i = 0; i < height - 6; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', i + 1), new string(' ', n - 3 - 2 * (i + 1)), new string('.', 2 * i + 1));
        }

        Console.WriteLine("*{0}*{1}*{0}*", new string('.', n / 2 - 1), new string('.', n - 3));
        Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n / 2), new string('*', (width - n - 3) / 2));
        Console.WriteLine(new string('*', width));
        Console.WriteLine(new string('*', width));
    }
}
