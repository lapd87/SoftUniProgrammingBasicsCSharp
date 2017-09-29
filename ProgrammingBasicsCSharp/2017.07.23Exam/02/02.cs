using System;

class Task02
{
    static void Main()
    {
        int steps = int.Parse(Console.ReadLine());
        int dancers = int.Parse(Console.ReadLine());
        int studyDays = int.Parse(Console.ReadLine());

        double stepsPerDay = Math.Ceiling((100.0 * steps / studyDays) / steps);
        double stepsPerDancer = stepsPerDay / dancers * 1.0;

        if (stepsPerDay <= 13)
        {
            Console.WriteLine("Yes, they will succeed in that goal! {0:0.00}%.", stepsPerDancer);
        }
        else
        {
            Console.WriteLine("No, They will not succeed in that goal! Required {0:0.00}% steps to be learned per day.", stepsPerDancer);
        }
    }
}
