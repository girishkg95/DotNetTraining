using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankComponent;

namespace BankClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsBank objSB = new SavingsBank(35000.00);

            Console.WriteLine("enter the principal amount");
            var pr = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the duration in years");
            var duration = int.Parse(Console.ReadLine());

            Console.WriteLine("enter rate of interest (%)");
            var rate = float.Parse(Console.ReadLine());

            var si = objSB.GetSimpleInterest(pr, duration, rate);

            Console.WriteLine("Simple Interst: Rs {0}", si);

            var balance = objSB.GetBalance();

            Console.WriteLine("Balance: Rs {0}", balance);

            Console.ReadLine();
        }
    }
}
