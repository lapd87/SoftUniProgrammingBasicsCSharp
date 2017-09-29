using System;

class NumberPyramid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int count = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i == count * (count + 1) / 2)
            {
                Console.WriteLine(i);
                count++;
            }
            else
            {
                Console.Write(i + " ");
            }
        }
    }
}
