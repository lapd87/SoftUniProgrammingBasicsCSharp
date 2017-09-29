using System;

class HalfSumElement
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());

        int sum = a;
        int max = a;

        for (int i = 2; i <= n; i++)
        {
            int b = int.Parse(Console.ReadLine());

            if (b > max)
            {
                max = b;
            }
            sum += b;
        }
        if (max == sum - max)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}", max);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", Math.Abs(sum - max - max));
        }
    }
}
