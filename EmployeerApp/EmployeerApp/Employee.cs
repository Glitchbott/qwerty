using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeerApp
{
    class Employee
    {
        private string emName;
        private int empId;
        private float currPay;

        public string GetName()
        {
            return emName;
        }

        public void  SetName( string name)
        {
            if (name.Length > 15)
                Console.WriteLine("Error! Name must be less than 16 characters!");
            else
                emName = name;
        }

        public Employee()
        {

        }
        public Employee( string name, int id, float pay)
        {
            emName = name;
            empId = id;
            currPay = pay;
        }

        public void GiveBonus (float amount )
        {
            currPay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine(" Name: {0}", emName);
            Console.WriteLine(" ID: {0}", empId);
            Console.WriteLine(" Pay: {0}", currPay);
        }



    }
}
