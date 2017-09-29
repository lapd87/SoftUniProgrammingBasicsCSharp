using System;

class MaxNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());


        int max = a;

        for (int i = 2; i <= n; i++)
        {
            int b = int.Parse(Console.ReadLine());

            if (max < b)
            {
                max = b;
            }
        }

        Console.WriteLine(max);
    }
}