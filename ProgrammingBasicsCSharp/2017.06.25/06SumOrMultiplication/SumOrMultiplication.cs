using System;

class SumOrMultiplication
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool found = false;

        for (int a = 1; a <= 30; a++)
        {
            for (int b = 1; b <= 30; b++)
            {
                for (int c = 1; c <= 30; c++)
                {
                    if (a < b && b < c && a + b + c == n)
                    {
                        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, n);
                        found = true;
                    }
                    if (a > b && b > c && a * b * c == n)
                    {
                        Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, n);
                        found = true;
                    }
                }
            }
        }
        if (!found)
        {
            Console.WriteLine("No!");
        }

    }
}
