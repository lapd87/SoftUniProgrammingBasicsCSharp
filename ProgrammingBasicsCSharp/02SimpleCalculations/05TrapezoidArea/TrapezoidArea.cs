using System;
class TrapezoidArea
{
    static void Main()
    {
        double b1 = double.Parse(Console.ReadLine());
        double b2 = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = (b1 + b2) / 2 * h;
        Console.WriteLine(area);
    }
}
