using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExamplе
{
    class Animal
    {
        public string petName;
        public string Action ;
        public void PrintState() 
        {
            Console.WriteLine(petName, Action);
        }

        public Animal()
        {
            petName = "";
            Action = "fly ";
            
        }

        public Animal(string pn)
        {
            petName = pn;
           
        }
        public Animal(string pn,string cs)
        {
            petName = pn;
            Action = cs;
            

        }
    }
}
