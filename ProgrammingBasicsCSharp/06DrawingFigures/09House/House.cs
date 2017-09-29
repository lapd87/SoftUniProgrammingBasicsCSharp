using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < (n + 1) / 2; row++)
        {
            int countDash = (n - 1) / 2 - row;
            int countStar = n - 2 * countDash;
            string dash = new string('-', countDash);
            string stars = new string('*', countStar);

            Console.WriteLine(dash + stars + dash);
        }

        for (int row = 0; row < n-(n+1)/2; row++)
        {
            Console.WriteLine('|'+new string('*',n-2)+'|');
        }
    }
}
