using System;

class Num1_N
{
    static void Main()
    {
        Console.Write("enter last number:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i += 1)
            Console.WriteLine(i);
    }
}

