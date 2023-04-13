using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using t1.BL;

namespace t1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            circle a1 = new circle();
            circle a2 = new circle(3.5);
            circle a3 = new circle(7.8,"blue");
            Console.WriteLine("\n");
            Console.WriteLine("DEFAULT");
            Console.WriteLine("\tRadius is: " +a1.rad+ "  Color is: "+a1.col);
            Console.WriteLine("\n");
            Console.WriteLine("PARAMETERIZED");
            Console.WriteLine("\tRadius is: " + a2.rad);
            Console.WriteLine("\n");
            Console.WriteLine("PARAMETERIZED");
            Console.WriteLine("\tRadius is: " + a3.rad + "  Color is: " + a3.col);
            Console.WriteLine("\n");
            Console.WriteLine("COPY CONSTRUCTOR");
            circle a4 = new circle(a1);
            a1.rad = 10.1;
            a1.col = "blue";
            Console.WriteLine("\tChange value of radius: "+a1.rad);
            Console.WriteLine("\tPrevious value of radius: "+a4.rad);
            Console.WriteLine("\tChange value of color: "+a1.col);
            Console.WriteLine("\tPrevious value of color: "+a4.col);
            Console.ReadKey();
        }
    }
}
