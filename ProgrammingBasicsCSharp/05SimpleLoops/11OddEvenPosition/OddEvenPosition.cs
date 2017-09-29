using System;

class OddEvenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double sumOdd = 0.0;
        double minOdd = double.MaxValue;
        double maxOdd = double.MinValue;
        double sumEven = 0.0;
        double minEven = double.MaxValue;
        double maxEven = double.MinValue;


        for (int i = 1; i <= n; i++)
        {
            double a = double.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                sumEven += a;
                if (a < minEven)
                {
                    minEven = a;
                }
                if (a > maxEven)
                {
                    maxEven = a;
                }
            }
            else
            {
                sumOdd += a;
                if (a < minOdd)
                {
                    minOdd = a;
                }
                if (a > maxOdd)
                {
                    maxOdd = a;
                }
            }
        }

        Console.WriteLine("OddSum="+sumOdd);
        if (minOdd == double.MaxValue)
        {
            Console.WriteLine("OddMin=No");
        }
        else
        {
            Console.WriteLine("OddMin="+minOdd);
        }
        if (maxOdd == double.MinValue)
        {
            Console.WriteLine("OddMax=No");
        }
        else
        {
            Console.WriteLine("OddMax="+maxOdd);
        }

        Console.WriteLine("EvenSum="+sumEven);
        if (minEven == double.MaxValue)
        {
            Console.WriteLine("EvenMin=No");
        }
        else
        {
            Console.WriteLine("EvenMin=" + minEven);
        }
        if (maxEven == double.MinValue)
        {
            Console.WriteLine("EvenMax=No");
        }
        else
        {
            Console.WriteLine("EvenMax=" + maxEven);
        }
    }
}
