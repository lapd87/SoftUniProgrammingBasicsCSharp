﻿using System;

class PointInRectangleBorder
{
    static void Main()
    {


        double rectangleX1 = double.Parse(Console.ReadLine());
        double rectangleY1 = double.Parse(Console.ReadLine());
        double rectangleX2 = double.Parse(Console.ReadLine());
        double rectangleY2 = double.Parse(Console.ReadLine());
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());


        if ((pointX == rectangleX1 || pointX == rectangleX2) &&
             pointY >= rectangleY1 && pointY <= rectangleY2)
        {
            Console.WriteLine("Border");
        }

        else if ((pointY == rectangleY1 || pointY == rectangleY2) &&
                  pointX >= rectangleX1 && pointX <= rectangleX2)
        {
            Console.WriteLine("Border");
        }

        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }
}
