
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectlnitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Object Init Syntax *****\n");

            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            Point anotherPoint = new Point(20, 20, " Red ");
            anotherPoint.DisplayStats();

            Point finalPoint = new Point{X = 30, Y = 30 };
            finalPoint.DisplayStats();
            Console.ReadLine();
       

        }
    }
}
