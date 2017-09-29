using System;


class InchToCM
{
    static void Main()
    {
        Console.Write("Inches = ");
        var inch = double.Parse(Console.ReadLine());
        var cm = inch * 2.54;
        Console.WriteLine(cm);
    }
}

