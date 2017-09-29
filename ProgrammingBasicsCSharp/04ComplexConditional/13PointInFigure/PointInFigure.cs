using System;

class PointInFigure
{
    static void Main()
    {

        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if ((x >= 0 && x <= 3 * h && y >= 0 && y <= h)
         || (x >= h && x <= 2 * h && y >= h && y <= 4 * h))
        {
            if ((x > 0 && x < 3 * h && y > 0 && y < h)
             || (x > h && x < 2 * h && y > h && y < 4 * h))
            {
                Console.WriteLine("inside");
            }
            else
            {
                if (x > h && x < 2 * h && y == h)
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("border");
                }
            }
        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}
