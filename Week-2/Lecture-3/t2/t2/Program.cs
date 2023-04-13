using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using t2.BL;

namespace t2
{
    class Program
    {
        static student add_product()
        {
            student p = new student();
            Console.WriteLine("Enter student name...");
            p.name = Console.ReadLine();
            Console.WriteLine("Enter student roll no...");
            p.roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student gpa...");
            p.gpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter you are hostelite or not...");
            p.hostelite = Console.ReadLine();
            Console.WriteLine("Enter student's department...");
            p.department = Console.ReadLine();
            add_infile(p);
            return p;
        }
        static void add_infile(student p)
        {
            string path = "file.txt";
            StreamWriter file = new StreamWriter(path,true);
            file.WriteLine(p.name + "," + p.roll + "," + p.gpa + "," + p.hostelite + "," + p.department);
            file.Flush();
            file.Close();
        }
        static void load_fromfile(List<student> a)
        {
            string path = "file.txt";
            StreamReader file = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while((record = file.ReadLine())!= null)
                {
                    student c = new student();
                    c.name = parseData(record, 1);
                    c.roll = int.Parse(parseData(record, 2));
                    c.gpa = float.Parse(parseData(record, 3));
                    c.hostelite = parseData(record, 4);
                    c.department = parseData(record, 5);
                    a.Add(c);
                }
                file.Close();               
               
            }
            else
            {
                Console.WriteLine(" Not exist ");
                Console.ReadKey();
            }
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma = comma + 1;
                }
                else if (comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
        static void show_student(List<student> a)
        {
            Console.WriteLine("Name\tRoll-No\tGPA\tHostellite\tDepartment");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i].name + "   " + a[i].roll + "   " + a[i].gpa + "    " + a[i].hostelite + "    " + a[i].department);

            }
            Console.ReadKey();
        }
        static void top(List<student> a)
        {
            float t=0;
            string temp1;
            int t1 = 0;
            for(int i=0;i<a.Count;i++)
            {
                for(int j=i+1;j<a.Count;j++)
                {
                    if(a[i].gpa < a[j].gpa)
                    {
                        t = a[i].gpa;
                        a[i].gpa = a[j].gpa;
                        a[j].gpa = t;

                        temp1 = a[i].name;
                        a[i].name = a[j].name;
                        a[j].name = temp1;

                        t1 = a[i].roll;
                        a[i].roll = a[j].roll;
                        a[j].roll = t1;

                        temp1 = a[i].hostelite;
                        a[i].hostelite = a[j].hostelite;
                        a[j].hostelite = temp1;

                        temp1 = a[i].department;
                        a[i].department = a[j].department;
                        a[j].department = temp1;
                    }
                }
            }
            Console.WriteLine("Name    Roll-No   GPA    Hostellite    Department");
            for(int i=0;i<3;i++)
            {
                Console.WriteLine(a[i].name + "   " + a[i].roll + "  " + a[i].gpa + "  " + a[i].hostelite + "  " + a[i].department);
            }
            Console.ReadKey();
        }
        static void main_menu()
        {
            Console.WriteLine(" _______________________");
            Console.WriteLine("|                       |");
            Console.WriteLine("|      MAIN MENU        |");
            Console.WriteLine("|_______________________|");
            Console.WriteLine("\n");
            Console.WriteLine("1- Add Students...");
            Console.WriteLine("2- Show Students...");
            Console.WriteLine("3- Top Students...");
            Console.WriteLine("\n");
            Console.WriteLine("Enter your option...");
        }
        static void Main(string[] args)
        {
            int option = 0;
            List<student> stu = new List<student>();
            while(option < 4)
            {
                option = 0;
                Console.Clear();
                main_menu();
                option = int.Parse(Console.ReadLine());
                if(option == 1)
                {
                    stu.Add(add_product());
                }
                if(option ==2)
                {
                    load_fromfile(stu);
                    show_student(stu);
                }
                if(option ==3)
                {                    
                    top(stu);
                }
            }
            Console.ReadKey();
        }
    }
}
