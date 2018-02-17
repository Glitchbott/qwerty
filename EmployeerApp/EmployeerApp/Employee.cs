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
        private int empAge;
        private string empSSN;
        public int Age
        {
            get { return empAge; }
            set { Age = value; }
        }

        public string Name
        {
            get { return emName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name must be less than 16 characters!");
                else
                    emName = value;
            }
        }
         public int Id
        {
            get { return empId; }
            set { empId = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
       


        public Employee() { }
        public Employee(string name, int id, float pay)
            :this (name, 0, id, pay , " ") { }
        public Employee( string name, int age, int id, float pay, string ssn)
        {
            emName = name;
            empId = id;
            currPay = pay;
            empAge = Age;
            empSSN = ssn;
        }

        public void GiveBonus (float amount )
        {
            Pay += amount;
        }
        public string SocialSecurityNumber
        {
            get { return empSSN ; }
        }

        public void DisplayStats()
        {
            Console.WriteLine(" Name: {0}", emName);
            Console.WriteLine(" ID: {0}", empId);
            Console.WriteLine(" Pay: {0}", currPay);
            Console.WriteLine(" Age: {0}", empId);
        }
    
    }
}
