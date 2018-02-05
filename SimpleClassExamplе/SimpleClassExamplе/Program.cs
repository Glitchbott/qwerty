using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExamplе
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Fun with Class Types ****\n");
            Car chuck = new Car();
            chuck.PrintState();

            Car mary = new Car("Mary");
            mary.PrintState();

            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            Console.ReadLine();
            

        }
    }
}
