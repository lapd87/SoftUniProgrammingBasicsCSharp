using System;

class TrainersSalary
{
    static void Main()
    {
        int lections = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());

        int jelevLections = 0;
        int royalLections = 0;
        int roliLections = 0;
        int trofonLections = 0;
        int sinoLections = 0;
        int otherLectors = 0;


        for (int i = 1; i <= lections; i++)
        {

            string name = Console.ReadLine();

            switch (name)
            {
                case "Jelev": jelevLections++; break;
                case "RoYaL": royalLections++; break;
                case "Roli": roliLections++; break;
                case "Trofon": trofonLections++; break;
                case "Sino": sinoLections++; break;
                default: otherLectors++; break;
            }
        }

        double salaryPerLection = budget / lections;
        Console.WriteLine("Jelev salary: {0:0.00} lv", salaryPerLection * jelevLections);
        Console.WriteLine("RoYaL salary: {0:0.00} lv", salaryPerLection * royalLections);
        Console.WriteLine("Roli salary: {0:0.00} lv", salaryPerLection * roliLections);
        Console.WriteLine("Trofon salary: {0:0.00} lv", salaryPerLection * trofonLections);
        Console.WriteLine("Sino salary: {0:0.00} lv", salaryPerLection * sinoLections);
        Console.WriteLine("Others salary: {0:0.00} lv", salaryPerLection * otherLectors);
    }
}
