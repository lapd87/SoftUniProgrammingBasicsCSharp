using System;

class Diamand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int rowCount = (n + 1) / 2 * 2 - 1;
        for (int row = 0; row < rowCount; row++)
        {
            int countOuterDash = Math.Abs((n - 1) / 2 - row);
            string outerDash = new string('-', countOuterDash);

            Console.Write(outerDash + "*");

            if (row == 0 || row == rowCount - 1)
            {
                if (n % 2 == 0)
                {
                    Console.Write("*");
                }
            }
            else
            {
                int countInnerDash = n - 2 * countOuterDash - 2;
                string innerDash = new string('-', countInnerDash);

                Console.Write(innerDash + "*");
            }

            Console.Write(outerDash);
            Console.WriteLine();
        }
    }
}



