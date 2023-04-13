using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1.BL
{
    class ladder:firetruck
    {
        private float length;
        private string color;

        public ladder(float length,string color)
        {
            this.length = length;
            this.color = color;
        }
        public void setLength(float length)
        {
            this.length = length;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
    }
}
