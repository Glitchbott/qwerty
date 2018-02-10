using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleUtilityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Fun whith Static Classes  *****\n");
            //РАБОТАЕТ
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();
            //НЕ РАБОТАЕТ
            TimeUtilClass u = new TimeUtilClass();
           Console.ReadLine();
                
        }

    }
}
