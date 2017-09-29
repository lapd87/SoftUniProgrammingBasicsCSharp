using System;

class GrapeRakia
{
    static void Main()
    {
        double grapeArea = double.Parse(Console.ReadLine());
        double grapePerSqM = double.Parse(Console.ReadLine());
        double badGrape = double.Parse(Console.ReadLine());

        double totalGrape = grapeArea * grapePerSqM - badGrape;
        double rakiaGrape = 0.45 * totalGrape;
        double sellGrape = 0.55 * totalGrape;
        double grapeMoney = sellGrape * 1.5;
        double rakiaMoney = rakiaGrape / 7.5 * 9.8;

        Console.WriteLine("{0:0.00}", rakiaMoney);
        Console.WriteLine("{0:0.00}", grapeMoney);
    }
}
