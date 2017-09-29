using System;

class FootbalLeague
{
    static void Main()
    {

        int capacity = int.Parse(Console.ReadLine());
        int totalFens = int.Parse(Console.ReadLine());


        int fens = totalFens;
        int sectorA = 0;
        int sectorB = 0;
        int sectorV = 0;
        int sectorG = 0;


        while (fens > 0)
        {
            string sector = Console.ReadLine().ToUpper();
            if (sector == "A")
            {
                sectorA++;
            }
            else if (sector == "B")
            {
                sectorB++;
            }
            else if (sector == "V")
            {
                sectorV++;
            }
            else if (sector == "G")
            {
                sectorG++;
            }
            fens--;
        }

        Console.WriteLine("{0:0.00}%", sectorA * 100.0 / totalFens);
        Console.WriteLine("{0:0.00}%", sectorB * 100.0 / totalFens);
        Console.WriteLine("{0:0.00}%", sectorV * 100.0 / totalFens);
        Console.WriteLine("{0:0.00}%", sectorG * 100.0 / totalFens);
        Console.WriteLine("{0:0.00}%", totalFens * 100.0 / capacity);


    }
}
