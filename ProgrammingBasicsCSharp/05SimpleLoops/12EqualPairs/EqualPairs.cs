using System;

class EqualPairs
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        double maxDiff = double.MinValue;
        double sumPrev = 0;
        double sumNow = 0;


        for (int i = 1; i <= n; i++)
        {
            sumPrev = sumNow;
            sumNow = 0;

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            sumNow = a + b;
            if (maxDiff < Math.Abs(sumNow - sumPrev) && i > 1)
            {
                maxDiff = Math.Abs(sumNow - sumPrev);
            }
        }

        if (n == 1 || sumPrev == sumNow)
        {
            Console.WriteLine("Yes, value={0}", sumNow);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}
