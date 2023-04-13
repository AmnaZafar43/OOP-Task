using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1.BL
{
    class hosepipe:firetruck
    {
        private string type;
        private string shape;
        private float diameter;
        private float flowRate;

        public hosepipe(string type,string shape,float diameter,float flowRate)
        {
            this.type = type;
            this.shape = shape;
            this.diameter = diameter;
            this.flowRate = flowRate;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public void setShape(string shape)
        {
            this.shape = shape;
        }
        public void setDiameter(float diameter)
        {
            this.diameter = diameter;
        }
        public void setFlow(float flowRate)
        {
            this.flowRate = flowRate;
        }
    }
}
