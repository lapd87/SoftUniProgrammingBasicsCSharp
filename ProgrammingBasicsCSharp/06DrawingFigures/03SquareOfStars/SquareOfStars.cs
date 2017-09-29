using System;

class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int k = 1; k <= n; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(new string(' ', n * 2));
        }
    }
}
