using System;

class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        int sum = 1;

        do
        {
            sum *= i;
            i++;
        } while (i <= n);

        Console.WriteLine(sum);
    }
}
