using System;

class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        if (n < 1)
        {
            Console.WriteLine(1);
        }
        else
        {

            int num1 = 0;
            int num2 = 1;

            int sum = 0;

            while (n > 0)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                n--;
            }

            Console.WriteLine(sum);
        }
    }
}
