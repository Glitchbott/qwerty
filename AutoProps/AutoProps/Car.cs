using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Car
    {
        public int Speed { get; set; }
        public string PetName { get; set; }
        public string Color { get; set; }
        public void DisplayStatus ()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Car Speed: {0}", Speed);
            Console.WriteLine("Car Color: {0}", Color);

        }
    }
}
