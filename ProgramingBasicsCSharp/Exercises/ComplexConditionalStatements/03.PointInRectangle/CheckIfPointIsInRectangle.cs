﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PointInRectangle
{
    class CheckIfPointIsInRectangle
    {
        static void Main(string[] args)
        {          
            double rectangleX1 = double.Parse(Console.ReadLine());
            double rectangleY1 = double.Parse(Console.ReadLine());
            double rectangleX2 = double.Parse(Console.ReadLine());
            double rectangleY2 = double.Parse(Console.ReadLine());
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());
            bool inside = false;

            if (pointX >= rectangleX1 && pointX <= rectangleX2 &&
                pointY >= rectangleY1 && pointY <= rectangleY2)
            {
                inside = true;
            }
            Console.WriteLine(inside ? "Inside" : "Outside");
        }
    }
}
