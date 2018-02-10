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
            Employee emp = new Employee("Marvinnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            emp.SetName("Marvnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnin");
            Console.WriteLine("Employee is named:{0}", emp.GetName());
            Console.ReadLine();
        }
    }
}
