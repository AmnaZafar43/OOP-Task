using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1.BL
{
    class mountainBike : Bicycle
    {
        private int seatHeight;

        public mountainBike(int seatHeight,int cadence,int gear,int speed): base(cadence,gear,speed)
        {
            this.seatHeight = seatHeight;
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }
        public void setSeatheight(int seatHeight)
        {
            this.seatHeight = seatHeight;
        }
    }
}
