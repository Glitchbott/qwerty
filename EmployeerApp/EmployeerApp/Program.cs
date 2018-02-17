using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Fun whith Encapsulation *****\n");
            Employee emp = new Employee("Marvin", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            emp.Name= "Marv";
            Console.WriteLine("Employee is named:{0}", emp.Name);
            Console.ReadLine();

            Employee joe = new Employee();
            joe.Age++; 


        }
    }
}
