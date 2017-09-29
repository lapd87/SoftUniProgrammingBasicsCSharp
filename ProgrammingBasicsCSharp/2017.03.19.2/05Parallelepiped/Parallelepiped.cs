using System;

class Parallelepiped
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int height = 4 * n + 4;
        int width = 3 * n + 1;

        string curly = new string('~', n-2);

        Console.WriteLine("+{0}+{1}", curly, new string('.', 2 * n + 1));

        int dotsBeforeCount = 0;
        int dotsAfterCount = 2 * n;

        for (int i = 0; i < 2 * n + 1; i++)
        {
            string dotsBefore = new string('.', dotsBeforeCount);
            string dotsAfter = new string('.', dotsAfterCount);

            Console.WriteLine("|{0}\\{1}\\{2}", dotsBefore, curly, dotsAfter);

            dotsAfterCount--;
            dotsBeforeCount++;
        }

        dotsBeforeCount = 0;
        dotsAfterCount = 2 * n;

        for (int i = 0; i < 2 * n + 1; i++)
        {
            string dotsBefore = new string('.', dotsBeforeCount);
            string dotsAfter = new string('.', dotsAfterCount);

            Console.WriteLine("{0}\\{1}|{2}|", dotsBefore, dotsAfter, curly);

            dotsAfterCount--;
            dotsBeforeCount++;
        }

        Console.WriteLine("{0}+{1}+", new string('.', 2 * n + 1), curly);
    }
}
