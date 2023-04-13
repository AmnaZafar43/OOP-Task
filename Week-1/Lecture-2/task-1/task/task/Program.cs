using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static int menu()
        {
            int option;
            Console.WriteLine("Sign-In");
            Console.WriteLine("Sign-Up");
            Console.WriteLine("Enter your option...");
            option = int.Parse(Console.ReadLine());
            return option;

        }
        static void Main(string[] args)
        {
            int result;
            result = menu();
        }
    }
}
