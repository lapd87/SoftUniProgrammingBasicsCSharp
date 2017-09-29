using System;

class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int Fibonacci(int a, int b, int count, int number)
        {
            if (count < number)
            {
                return Fibonacci(b, a + b, count + 1, number);
            }

            else
            {
                Console.WriteLine(a + b);
                return 0;
            }
        }
        Fibonacci(0, 1, 1, n);
    }
}
