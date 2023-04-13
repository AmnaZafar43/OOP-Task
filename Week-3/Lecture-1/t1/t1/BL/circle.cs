using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1.BL
{
    class circle
    {
        public circle()
        {
            col = "red";
            rad = 1.0F;
        }
        public circle(double radius)
        {
            rad = radius;
        }
        public circle(double radius,string color)
        {
            rad = radius;
            col = color;
        }
        public circle(circle a1)
        {
            col = a1.col;
            rad = a1.rad;
        }
        public string col;
        public double rad;
    }
}
