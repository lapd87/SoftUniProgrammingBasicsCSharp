using System;

class Styrofoam
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        double houseArea = double.Parse(Console.ReadLine());
        int windowsCount = int.Parse(Console.ReadLine());
        double styrofoamPackArea = double.Parse(Console.ReadLine());
        double styrofoamPackPrice = double.Parse(Console.ReadLine());

        double coveringArea = (houseArea - windowsCount * 2.4) * 1.1;
        double styrofoamPackNeeded = Math.Ceiling(coveringArea / styrofoamPackArea);
        double budgetNeeded = styrofoamPackNeeded * styrofoamPackPrice;

        if (budgetNeeded <= budget)
        {
            Console.WriteLine("Spent: {0:0.00}", budgetNeeded);
            Console.WriteLine("Left: {0:0.00}", budget-budgetNeeded);
        }
        else
        {
            Console.WriteLine("Need more: {0:0.00}", budgetNeeded-budget);
        }
    }
}
