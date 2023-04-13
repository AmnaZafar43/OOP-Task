using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_1.BL;

namespace task_1.UI
{
    class takeInput
    {
        public static void takeCoordinates()
        {
            int X, Y, X1, Y1;
            myPoint point = new myPoint();
            Console.WriteLine("Enter value of X coordinate.....");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of Y coordinate.....");
            Y = int.Parse(Console.ReadLine());
            point.setx(X);
            point.sety(Y);
            Console.WriteLine("\n");
            Console.WriteLine("Enter new value of X coordinate....");
            X1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new value of Y coordinate.....");
            Y1 = int.Parse(Console.ReadLine());
            point.distance(X1, Y1);
            Console.WriteLine("Distance of two points is {0} ", point.distance(X1, Y1));
            Console.ReadKey();
        }
    }
}
