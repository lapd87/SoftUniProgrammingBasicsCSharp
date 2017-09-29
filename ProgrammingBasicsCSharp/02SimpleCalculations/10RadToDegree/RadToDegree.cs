using System;

class RadToDegree
{
    static void Main()
    {
        double rad = double.Parse(Console.ReadLine());
        double degree = rad * 180 / Math.PI;
        Console.WriteLine(Math.Round(degree, 2));
    }
}

