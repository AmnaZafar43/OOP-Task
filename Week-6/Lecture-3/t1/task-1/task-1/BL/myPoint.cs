using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1.BL
{
    class myPoint
    {
        private int x;
        private int y;

        public myPoint()
        {
            x = 0;
            y = 0;
        }
        public myPoint(int X,int Y)
        {
            this.x = X;
            this.y = Y;
        }
        public int getx()
        {
            return x;
        }
        public int gety()
        {
            return y;
        }
        public void setx(int X)
        {
            x = X;
        }
        public void sety(int Y)
        {
            y = Y;
        }
        public double distance(int X1,int Y1)
        {
            double d;
            d = ((X1 - x) * (X1 - x)) + ((Y1 - y) * (Y1 - y));
            d = Math.Sqrt(d);
            return d;
        }
    }
}
