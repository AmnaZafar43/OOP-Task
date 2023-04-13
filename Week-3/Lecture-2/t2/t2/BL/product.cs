using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace t2.BL
{
    class product
    {
        public string name;
        public string category;
        public int price;
        public string quantity;
        public string minimum_quantity;
        public double sales_tax(product temp)
        {
                double tax = 0.0D;    
                if (temp.category == "grocery" || temp.category == "Grocery")
                {
                    tax = (temp.price * 10.0) / 100.0;

                }
                else if (temp.category == "fruit" || temp.category == "Fruit")
                {
                    tax = (temp.price * 5.0) / 100.0;
                }
                else
                {
                    tax = (temp.price * 15.0) / 100.0;
                }           
            return tax;
        }

    }
}
