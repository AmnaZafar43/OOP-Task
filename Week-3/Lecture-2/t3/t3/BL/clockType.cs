using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3.BL
{
    class clockType
    {
        public string firstName;
        public string lastName;
        public int age;
        public double salary;
        public clockType(string firstName,string lastName,int age,double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }
        public clockType(double salary)
        {
            this.salary = salary;
        }
        public string full_name(string firstName, string lastName)
        {
            string fullName;
            fullName = firstName + lastName;
            return fullName;
        }
        public double increment_salary(double salary)
        {
            double i_salary;
            i_salary = (salary * 0.1) + salary;
            return i_salary;
        }
        public void result()
        {
            Console.WriteLine("Your full name is {0}  and your total salary is {1}",this.full_name(this.firstName,this.lastName), this.increment_salary(this.salary));

        }
    }
}
