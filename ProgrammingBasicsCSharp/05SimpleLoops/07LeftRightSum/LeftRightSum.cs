using System;

class LeftRightSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sumLeft = 0;
        int sumRight = 0;


        for (int i = 1; i <= 2 * n; i++)
        {
            int b = int.Parse(Console.ReadLine());

            if (i <= n)
            {
                sumRight += b;
            }
            else
            {
                sumLeft += b;
            }
        }
        if (sumLeft == sumRight)
        {
            Console.WriteLine("Yes, sum = {0}", sumLeft);

        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(sumLeft - sumRight));
        }
    }
}
