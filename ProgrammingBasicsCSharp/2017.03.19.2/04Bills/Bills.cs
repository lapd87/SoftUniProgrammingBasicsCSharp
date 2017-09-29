using System;

class Bills
{
    static void Main()
    {
        int months = int.Parse(Console.ReadLine());
        double electricSum = 0;

        for (int i = 0; i < months; i++)
        {
            double electric = double.Parse(Console.ReadLine());
            electricSum += electric;
        }

        double waterSum = 20 * months;
        double internetSum = 15 * months;
        double otherSum = (electricSum + waterSum + internetSum) * 1.2;
        double totalSum = electricSum + waterSum + internetSum + otherSum;
        double average = totalSum / months;


        Console.WriteLine("Electricity: {0:0.00} lv", electricSum);
        Console.WriteLine("Water: {0:0.00} lv", waterSum);
        Console.WriteLine("Internet: {0:0.00} lv", internetSum);
        Console.WriteLine("Other: {0:0.00} lv", otherSum);
        Console.WriteLine("Average: {0:0.00} lv", average);
    }
}
