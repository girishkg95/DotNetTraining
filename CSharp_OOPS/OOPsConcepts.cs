using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();  //Instantiation of Employee class using 'new'                                      keyword

            Employee emp1 = new Employee(1, "Robert",2,"Admin");  //Initializing class fields                                                        using the constructor

            Employee emp2 = new Employee(2, "Jeffrey", 3, "Technical");

            emp1.ShowData();        //instance method should be called with an object reference
            emp2.ShowData();


            Product prd = new Product() { ProductID = 1, ProductName = "Badam Drink", Price = 95.00, Quantity = "500 ml" };

            prd.ShowData();

            Customer customer = new Customer() { CustomerID = 18, CustomerName = "Anders Helsberg", Country = "USA" };

            customer.ShowData();
        }
    }

    public class Employee   //Access specifier for class is internal by default
    {
        int empid;      //Access specifier is private by default for class members
        string empname;
        short deptid;
        string deptname;

        public Employee()               //default constructor
        { }

        //public Employee(int eid,string ename)         //constructor with 2 parameters
        //{
        //    empid = eid;
        //    empname = ename;
        //}

        public Employee(int eid,string ename,short did,string dname)  //constructor with 4                                                                    parameters
        {
            empid = eid;
            empname = ename;
            deptid = did;
            deptname = dname;
        }

        public void ShowData()                              //this is an instance method
        {
            Console.WriteLine("\nEmpID = {0}", empid);
            Console.WriteLine("EmpName = {0}", empname);
            Console.WriteLine("DeptID = {0}", deptid);
            Console.WriteLine("DeptName = {0}", deptname);
        }
    }

    //Access Specifiers
    //private, protected, public, internal, protected internal
    //private - can only be accessed within the class where it is defined
    //protected - can only be accessed within both its base and derived class
    //public - can be accessed anywhere both within or outside of that class or assembly
    //internal - can be accessed only within the current assembly of where that class is defined
    //protected internal - can be accessed anywhere within the current assembly and only within the derived class of that assembly

    public class Product
    {
        int pid;

        //defining properties for the class
        public int ProductID
        {
            get { return pid; }
            set { pid = value; }
        }

        //Automatic properties, compiler does the implementation here
        public string ProductName
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public string Quantity
        {
            get;
            set;
        }
        
        public void ShowData()
        {
            Console.WriteLine("\nProductID = {0}", ProductID);
            Console.WriteLine("ProductName = {0}", ProductName);
            Console.WriteLine("Price = {0}", Price);
            Console.WriteLine("Quantity = {0}", Quantity);
        }

    }

    public class Customer
    {
        int cid;

        public int CustomerID
        {
            get { return cid; }
            set { cid = value; }
        }

        public string CustomerName
        {
            get;
            set;
        }

        public string Country
        {
            get;
            set;
        }

        public void ShowData()
        {
            Console.WriteLine("\nCustomerID = {0}", CustomerID);
            Console.WriteLine("Name = {0}", CustomerName);
            Console.WriteLine("Country = {0}",Country);
        }
    }
}
