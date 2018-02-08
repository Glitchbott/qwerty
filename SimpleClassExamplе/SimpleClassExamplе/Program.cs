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
            Animal henry = new Animal("Henry", "run"); ;
            henry.PrintState();

            Animal mary = new Animal("Mary", "run");
            mary.PrintState();

            Animal daisy = new Animal("Daisy", "fly");
            daisy.PrintState();

            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0} , c.name");

            Console.ReadLine();
            

        }
    }
}
