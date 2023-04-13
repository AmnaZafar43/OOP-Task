using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using t3.BL;

namespace t3
{
    class Program
    {
        static void main_menu()
        {
            Console.WriteLine(" ______________________");
            Console.WriteLine("|                      |");
            Console.WriteLine("|     MAIN MENU        |");
            Console.WriteLine("|______________________|");
            Console.WriteLine("\n");
            Console.WriteLine("1- SIGN_UP");
            Console.WriteLine("2- SIGN_IN");
            Console.WriteLine("3- EXIT");
            Console.WriteLine("\n");
            Console.WriteLine("Enter you option...");
        }
        static credentials sign_up()
        {
            credentials b = new credentials();
            Console.WriteLine("Enter username...");
            b.username = Console.ReadLine();
            Console.WriteLine("Enter password...");
            b.password = Console.ReadLine();
            add_infile(b);
            return b;
        }
        static void add_infile(credentials a)
        {
            string path = "file.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(a.username + "," + a.password);
            file.Flush();
            file.Close();
        }
        static void load_fromfile(List<credentials> a1)
        {          
            string path = "file.txt";
            StreamReader file = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while((record = file.ReadLine())!=null)
                {
                    credentials p = new credentials();
                    p.username = parseData(record, 1);
                    p.password = parseData(record, 2);
                    a1.Add(p);
                }
                file.Close();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(" not exist ");
                Console.ReadKey();
            }
        }
        static string parseData(string record,int field)
        {
            int comma = 1;
            string item = "";
            for(int i=0;i<record.Length;i++)
            {
                if(record[i] == ',')
                {
                    comma = comma + 1;
                }
                else if(comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
        static void sign_in(List<credentials> a1)
        {
            credentials p = new credentials();
            Console.WriteLine("Enter username...");
            p.username = Console.ReadLine();
            Console.WriteLine("Enter password...");
            p.password = Console.ReadLine();
            for(int i=0;i<a1.Count;i++)
            {
                if(p.username == a1[i].username && p.password == a1[i].password)
                {
                    Console.WriteLine("\n\tValid user");
                   
                }
                else
                {
                    Console.WriteLine("Invalid User");
                    break;
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {          
            List<credentials> a = new List<credentials>();
            int option = 0;
            while(option < 4)
            {
                Console.Clear();
                main_menu();
                option = int.Parse(Console.ReadLine());
                if(option == 1)
                {
                    a.Add(sign_up());
                }
                if(option == 2)
                {
                    load_fromfile(a);                                   
                    sign_in(a);
                }
                if(option == 3)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
