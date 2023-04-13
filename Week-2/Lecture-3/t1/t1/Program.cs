using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using t1.BL;

namespace t1
{
    class Program
    {
        static store add_product()
        {
            store p = new store();
            Console.WriteLine("Enter product name...");
            p.name = Console.ReadLine();
            Console.WriteLine("Enter product id...");
            p.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product price...");
            p.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product category...");
            p.category = Console.ReadLine();
            Console.WriteLine("Enter product brand-name...");
            p.brand = Console.ReadLine();
            Console.WriteLine("Enter product country...");
            p.country = Console.ReadLine();
            add_infile(p);
            return p;
        }
        static void add_infile(store p)
        {
            string path = "file.txt";
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(p.name + "," + p.id + "," + p.price + "," + p.category + "," + p.brand + "," + p.country);
            file.Flush();
            file.Close();
        }
        static void load_fromfile(List<store> c)
        {
            string path = "file.txt";
            StreamReader file = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while((record = file.ReadLine())!=null)
                {
                    store a = new store();
                    a.name = parseData(record, 1);
                    a.id = int.Parse(parseData(record, 2));
                    a.price = int.Parse(parseData(record, 3));
                    a.category = parseData(record, 4);
                    a.brand = parseData(record, 5);
                    a.country = parseData(record, 6);                   
                    c.Add(a);
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("File not exist");
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
        static void show_product(List<store> a)
        {
            Console.WriteLine("Name     ID    Price    Category   Brand   Country");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i].name + "   " + a[i].id + "   " + a[i].price + "    " + a[i].category + "    " + a[i].brand + "     " + a[i].country);

            }
            Console.ReadKey();
        }
        static void total_worth(List<store> a)
        {
            int sum = 0;
            for (int i = 0; i < a.Count; i++)
            {
                sum = sum + a[i].price;
            }
            Console.WriteLine("Total worth is {0} ", sum);
            Console.ReadKey();
        }
        static void main_menu()
        {
            Console.WriteLine(" _______________________");
            Console.WriteLine("|                       |");
            Console.WriteLine("|      MAIN MENU        |");
            Console.WriteLine("|_______________________|");
            Console.WriteLine("\n");
            Console.WriteLine("1- Add Product...");
            Console.WriteLine("2- Show Product...");
            Console.WriteLine("3- Total Store Worth...");
            Console.WriteLine("\n");
            Console.WriteLine("Enter your option...");
        }
        static void Main(string[] args)
        {
            int sum = 0, sizes = 0, i = 0, option = 0;
            List<store> a = new List<store>();
            while(option < 4)
            {
                option = 0;
                Console.Clear();
                main_menu();
                option = int.Parse(Console.ReadLine());
                if(option == 1)
                {
                    a.Add(add_product());
                }
                if(option ==2)
                {
                    load_fromfile(a);
                    show_product(a);
                }
                if(option ==3)
                {
                    total_worth(a);
                }
            }
        }
    }
}
