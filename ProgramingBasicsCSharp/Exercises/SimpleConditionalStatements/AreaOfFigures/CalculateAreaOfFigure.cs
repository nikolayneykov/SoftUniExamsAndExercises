using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class CalculateAreaOfFigure
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;
            if (figure=="square")
            {
                double side = double.Parse(Console.ReadLine());
                area = Math.Round((side * side), 3);
            }
            else if (figure== "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double length = double.Parse(Console.ReadLine());
                area = Math.Round((width * length), 3);
            }
            else if (figure== "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.Round((Math.PI * radius * radius),3);
            }
            else if (figure=="triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = Math.Round((side*height/2),3);
            }
            Console.WriteLine(area);
        }
    }
}
