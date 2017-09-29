using System;

class CheckPrime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int i = 2;

        if (n < 2)
        {
            Console.WriteLine("Not Prime");
            return;
        }

        while (i <= Math.Sqrt(n))
        {
            if (n % i == 0)
            {
                Console.WriteLine("Not Prime");
                return;
            }
            i++;
        }
        Console.WriteLine("Prime");
    }
}
