using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using t3.BL;

namespace t3
{
    class Program
    {
        static void Main(string[] args)
        {
            string first, last;
            int ages;
            double salry;           
            Console.WriteLine("Enter first name");
            first = Console.ReadLine();
            Console.WriteLine("Enter last name");
            last = Console.ReadLine();
            Console.WriteLine("Enter age");
            ages = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter salary");
            salry = float.Parse(Console.ReadLine());
            clockType clock = new clockType(first,last,ages,salry);
            clock.result();
            clockTypeDL cDl = new clockTypeDL();
            cDl.addData_inlist(clock);
            foreach(clockType obj in clockTypeDL.clock)
            {
                Console.WriteLine(obj.firstName);
            }
            Console.ReadKey();

        }
    }
}
