using System;

class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }

        Console.WriteLine(Factorial(n));
    }
}
