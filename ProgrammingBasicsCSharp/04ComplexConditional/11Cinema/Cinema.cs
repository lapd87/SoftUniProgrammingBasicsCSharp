using System;

class Cinema
{
    static void Main()
    {
        string projection = Console.ReadLine().ToLower();
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (projection == "premiere")
        {
            Console.WriteLine("{0:0.00} leva", r * c * 12);
        }
        else if (projection == "normal")
        {
            Console.WriteLine("{0:0.00} leva", r * c * 7.5);
        }
        else if (projection == "discount")
        {
            Console.WriteLine("{0:0.00} leva", r * c * 5);
        };
    }
}
