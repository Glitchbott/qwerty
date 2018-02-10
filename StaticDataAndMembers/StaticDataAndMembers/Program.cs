using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun whith Static Data *****\n");
            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);
            Console.WriteLine("Inerest Rate is: {0}", SavingsAccount.GetInterestRate());
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Inerest Rate is: {0}", SavingsAccount.GetInterestRate());
            Console.ReadLine();

        }
    }
}
