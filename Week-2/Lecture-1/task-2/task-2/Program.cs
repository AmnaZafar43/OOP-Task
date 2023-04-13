using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_2.BL;

namespace task_2
{
    class Program
    {
        static void add_student(student[] a,int count)
        {
            Console.WriteLine("Enter student name... ");
            a[count].name = Console.ReadLine();
            Console.WriteLine("Enter student roll no... ");
            a[count].roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student GPA... ");
            a[count].gpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter you are hostellite or not... ");
            a[count].hostelite = Console.ReadLine();
            Console.WriteLine("Enter which department ")
        }
        static void Main(string[] args)
        {
            int count = 0;
            student[] arr = new student[5];
            int option;
            Console.WriteLine(" ___________________________");
            Console.WriteLine("|                           |");
            Console.WriteLine("|                           |");
            Console.WriteLine("|       MAIN MENU           |");
            Console.WriteLine("|                           |");
            Console.WriteLine("|___________________________|");
            Console.WriteLine("\n");
            Console.WriteLine("1- Add Student..");
            Console.WriteLine("2- Show Student..");
            Console.WriteLine("3- Top Student..");
            Console.WriteLine("\n");
            Console.WriteLine("Enter your option.. ");
            option = int.Parse(Console.ReadLine());
            while(option < 4)
            {
                if(option == 1)
                {
                    add_student(arr,count);
                }
            }
            

        }
    }
}
