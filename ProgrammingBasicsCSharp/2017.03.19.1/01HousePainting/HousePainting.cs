using System;

class HousePainting
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:0.00}", (x * x * 2 - 1.2 * 2 + x * y * 2 - 1.5 * 1.5 * 2) / 3.4);
        Console.WriteLine("{0:0.00}", (2 * x * y + h * x) / 4.3);
    }
}
