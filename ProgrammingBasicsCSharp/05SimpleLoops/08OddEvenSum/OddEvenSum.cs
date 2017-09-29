using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sumOdd = 0;
        int sumEven = 0;


        for (int i = 1; i <= n; i++)
        {
            int b = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                sumOdd  += b;
            }
            else
            {
                sumEven += b;
            }
        }
        if (sumOdd == sumEven)
        {
            Console.WriteLine("Yes, sum = {0}", sumOdd);

        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(sumOdd - sumEven));
        }
    }
}
