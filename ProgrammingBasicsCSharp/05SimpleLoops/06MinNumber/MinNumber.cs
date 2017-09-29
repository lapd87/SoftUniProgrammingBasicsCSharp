using System;

class MinNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());


        int min = a;

        for (int i = 2; i <= n; i++)
        {
            int b = int.Parse(Console.ReadLine());

            if (min > b)
            {
                min = b;
            }
        }

        Console.WriteLine(min);
    }
}
