using System;

class ControlNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int control = int.Parse(Console.ReadLine());
        int sum = 0;
        int moves = 0;


        for (int i = 1; i <= n; i++)
        {
            for (int k = m; k >= 1; k--)
            {
                sum += i * 2 + k * 3;
                moves++;

                if (sum >= control)
                {
                    Console.WriteLine(moves + " moves");
                    Console.WriteLine("Score: {0} >= {1}", sum, control);
                    return;
                }
            }
        }

        Console.WriteLine(moves + " moves");

    }
}
