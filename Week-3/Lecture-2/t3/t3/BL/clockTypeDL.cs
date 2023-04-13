using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3.BL
{
    class clockTypeDL
    {
        public static List<clockType> clock = new List<clockType>(); 
        public void addData_inlist(clockType temp)
        {
            clock.Add(temp);
        }
    }
}
