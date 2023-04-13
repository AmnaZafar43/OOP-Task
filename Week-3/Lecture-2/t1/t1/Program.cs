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
        static void main_menu()
        {
            Console.WriteLine("\n\t 1- Get Area ");
            Console.WriteLine("\n\t 2- Get Diameter ");
            Console.WriteLine("\n\t 3- Get Circumference ");
            Console.WriteLine("\n");
            Console.WriteLine("Enter your option...");
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            double result =0.0D;
            circle a = new circle();
            circle b = new circle();
            circle c = new circle();           
            int option = 0;           
            while (option < 4)
            {
                Console.Clear();
                option = 0;
                main_menu();
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    result = a.getArea();
                    Console.WriteLine("Area of circle is {0} ", result);
                    Console.ReadKey();
                }
                if (option == 2)
                {
                    result = b.getDiameter();
                    Console.WriteLine("Area of circle is {0} ", result);
                    Console.ReadKey();
                }
                if (option == 3)
                {
                    result = b.getCircumference();
                    Console.WriteLine("Area of circle is {0} ", result);
                    Console.ReadKey();
                }
            }
            Console.ReadKey();          
        }
    }
}
