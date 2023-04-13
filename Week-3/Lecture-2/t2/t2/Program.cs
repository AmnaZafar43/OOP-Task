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
        static void main_menu()
        {
            Console.WriteLine("\n\t*******************************");
            Console.WriteLine("\n\t* SNOWBALL DEPARTMENTAL STORE *");
            Console.WriteLine("\n\t*                             *");
            Console.WriteLine("\n\t*******************************");
            Console.WriteLine("\n");
            Console.WriteLine("\t1- Add Products");
            Console.WriteLine("\t2- View All Products");
            Console.WriteLine("\t3- Find product with highest unit price");
            Console.WriteLine("\t4- View sales tax of all product");
            Console.WriteLine("\t5- Product to be ordered");
            Console.WriteLine("\n");
        }
        static int main_option()
        {
            int option = 0;
            Console.WriteLine("Enter your option...");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static product add_product()
        {
            product b = new product();
            Console.WriteLine("Enter product name...");
            b.name = Console.ReadLine();
            Console.WriteLine("Enter product category...");
            b.category = Console.ReadLine();
            Console.WriteLine("Enter product price...");
            b.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product stock quantity...");
            b.quantity = Console.ReadLine();
            Console.WriteLine("Enter minimum stock of quantity...");
            b.minimum_quantity = Console.ReadLine();
            add_infile(b);
            return b;
        }
        static void add_infile(product b)
        {
            string path = "file.txt";
            StreamWriter file = new StreamWriter(path,true);
            file.WriteLine(b.name + "," + b.category + "," + b.price + "," + b.quantity + "," + b.minimum_quantity);
            file.Flush();
            file.Close();
        }
        static void load_fromfile(List<product> a)
        {
           
            string path = "file.txt";
            StreamReader file = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while((record = file.ReadLine())!=null)
                {
                    product c = new product();
                    c.name = parseData(record, 1);
                    c.category = parseData(record, 2);
                    c.price= int.Parse(parseData(record, 3));
                    c.quantity = parseData(record, 4);
                    c.minimum_quantity = parseData(record, 5);
                    a.Add(c);
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("File doesn't exist...");
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
        static void view_product(List<product> a)
        {
            Console.WriteLine("NAME\t     CATEGORY\tPRICE\tQUANTITY\tMINIMUM_QUANTITY");
            for(int i=0;i<a.Count;i++)
            {
                Console.WriteLine(a[i].name + "    \t" + a[i].category + "\t" + a[i].price + "\t" + a[i].quantity + "\t" + a[i].minimum_quantity);
            }
            Console.ReadKey();
        }
        static void find_high(List<product> a)
        {
            int idx = 0;
            int max = 0;
            for(int i=0;i<a.Count;i++)
            {
                if(a[i].price > max)
                {
                    max = a[i].price;
                    idx = i;
                }
            }
            Console.WriteLine("NAME\tCATEGORY\tPRICE\tQUANTITY\tMINIMUM QUANTITY");
            Console.WriteLine(a[idx].name + "\t" + a[idx].category + "\t" + max + "\t" + a[idx].quantity + "\t" + a[idx].minimum_quantity);
            Console.ReadKey();
        }
        static void view_salestax(List<product> a)
        {
            double total_tax = 0;
            product p = new product();
            for(int i=0;i<a.Count;i++)
            {
                total_tax = total_tax + p.sales_tax(a[i]);
            }
            Console.WriteLine("Total Sales tax is {0}", total_tax);
            Console.ReadKey();
        }
        static void add_intolist(product temp,List<product> a)
        {
            a.Add(temp);
        }
        static void Main(string[] args)
        {
            product temp = new product();
            List<product> a = new List<product>();
            int op = 0;
            while(op < 6)
            {
                Console.Clear();            
                op = 0;
                main_menu();
                op = main_option();
                if (op == 1)
                {                  
                    temp = add_product();
                    add_intolist(temp, a);
                }
                if (op == 2)
                {
                    load_fromfile(a);
                    view_product(a);
                }
                if (op == 3)
                {                   
                    find_high(a);
                }
                if (op == 4)
                {
                    view_salestax(a);
                }
                if (op == 5)
                {

                }
            }
            Console.ReadKey();
        }
    }
}
