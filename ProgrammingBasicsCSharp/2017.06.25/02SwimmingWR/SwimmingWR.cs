using System;

class SwimmingWR
{
    static void Main()
    {
        double secondsWR = double.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        double speedPerM = double.Parse(Console.ReadLine());

        double waterResistanceSec = Math.Floor(distance / 15.0) * 12.5;
        double swimTime = Math.Round(distance * speedPerM + waterResistanceSec, 2);

        if (secondsWR <= swimTime)
        {
            Console.WriteLine("No, he failed! He was {0:0.00} seconds slower.", swimTime - secondsWR);
        }
        else
        {
            Console.WriteLine("Yes, he succeeded! The new world record is {0:0.00} seconds.", swimTime);
        }

    }
}
