using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, price_toy, save_money = 0, total = 0, count = 0;
            int sold_toy, amount, buy;
            int price_machine;
            Console.Write("Enter age of lilly: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter price of washing machine: ");
            price_machine = int.Parse(Console.ReadLine());
            Console.Write("Enter price of toy: ");
            price_toy = int.Parse(Console.ReadLine());
            if (age % 2 == 0)
            {
                for (int i = 2; i <= age; i = i + 2)
                {
                    save_money = save_money + 10;
                    total = total + save_money; // how much money she save
                }
                for (int i = 0; i <= age; i++)
                {
                    if (i % 2 != 0)
                    {
                        count = count + 1;  //how many toys she sold
                    }
                }
                sold_toy = count * price_toy; // amount she got after solding the toys
               
                amount = total + sold_toy - count; // total amount she have
                buy = amount - price_machine; // money she left 
                if (amount > price_machine)
                {
                    Console.Write("Yes!" + buy);
                }
                else
                {
                    Console.Write("No!" + buy);
                }
            }
            else
            {

            }
            Console.ReadKey();
        }
    }
}
