using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1.BL
{
    class circle
    {
        public float radius;
        public float diameter;
        public double getArea()
        {
            double area;
            Console.WriteLine("Enter radius... ");
            radius = float.Parse(Console.ReadLine());
            area = 3.14 * radius * radius;
            return area;
        }
        public double getDiameter()
        {
            double dia;
            Console.WriteLine("Enter radius... ");
            radius = float.Parse(Console.ReadLine());
            dia = 2 * radius;
            return dia;
        }
        public double getCircumference()
        {
            double cir;
            Console.WriteLine("Enter radius... ");
            radius = float.Parse(Console.ReadLine());
            cir = 2 * 3.14 * radius;
            return cir;
        }

    }
}
