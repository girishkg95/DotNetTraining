using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemoProg
{
    class Program
    {
        static void Main(string[] args)
        {
            SBAccount objSB = new SBAccount();

            CCAccount objCC = new CCAccount();

            double siSB = objSB.GetSimpleInterest(95000.00, 5, 8);
            double tamt = objSB.GetTotalAmount(50000.00, siSB);

            Console.WriteLine("Simple Interest(Savings Bank): Rs {0}", siSB);
            Console.WriteLine("Total Amount: Rs {0}", tamt);


            var siCC = objCC.GetSimpleInterest(95000.00, 5, 8);
            tamt = objCC.GetTotalAmount(50000.00, siCC);

            Console.WriteLine("Simple Interest(Current Account): Rs {0}", siCC);
            Console.WriteLine("Total Amount: Rs {0}", tamt);

            objSB.Show();  //Calling the concrete method defined within the Banking base class
        }
    }

    public abstract class Banking
    {
        public abstract double GetSimpleInterest(double pr, int td, short rt);
        public abstract double GetTotalAmount(double bal,double si);

        public void Show()
        {
            Console.WriteLine("This is a concrete method defined within an abstract class");
        }
    }

    public class SBAccount : Banking
    {
        public override double GetSimpleInterest(double pr, int td, short rt)
        {
            double si = (pr * td * rt) / 100;
            return si;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }
    }

    public class CCAccount : Banking
    {
        public override double GetSimpleInterest(double pr, int td, short rt)
        {
            double si = 0.25*((pr * td * rt) / 100);  //only 25% interest as that of SB Account
            return si;
        }

        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }
    }
}
