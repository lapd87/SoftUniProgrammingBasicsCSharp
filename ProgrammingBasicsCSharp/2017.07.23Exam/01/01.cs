using System;

class task01
{
    static void Main()
    {
        double l = double.Parse(Console.ReadLine());
        double w = double.Parse(Console.ReadLine());
        double a = double.Parse(Console.ReadLine());

        double hallArea = l * 100.0 * w * 100.0;
        double wardrobeArea = a * 100.0 * a * 100.0;
        double benchArea = hallArea / 10.0;

        double freeSpace = hallArea - wardrobeArea - benchArea;

        double dancers = Math.Floor(freeSpace / 7040.0);

        Console.WriteLine(dancers);
    }
}
