using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessConsoleApp
{
    class Program
    {
        static string conString, qryString;
        static SqlConnection sqlCon;
        static SqlCommand sqlCmd;
        static SqlDataReader dr;
        static SqlDataAdapter da;
        static DataSet ds;

        static void Main(string[] args)
        {
            conString = "data source=BLUESAPPHIRE\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            using (sqlCon = new SqlConnection(conString))
            {
                qryString = "Select ProductID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products";
                sqlCmd = new SqlCommand(qryString, sqlCon);
                sqlCon.Open();
                dr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(dr.Read())
                {
                    Console.WriteLine("ProductID: {0}, Name: {1}, Price: {2}, Quantity: {3}, CategoryID: {4}", dr["ProductID"].ToString(), dr["ProductName"].ToString(), dr["UnitPrice"].ToString(), dr["QuantityPerUnit"].ToString(), dr["CategoryID"].ToString());
                }
                dr.Close();
                sqlCon.Close();

                LINQToDataSets();
            }
        }
        public static void LINQToDataSets()
        {
            qryString = "select CustomerID,CompanyName,ContactName,Address,Country from Customers";
            using (sqlCon = new SqlConnection(conString))
            {
                sqlCmd = new SqlCommand(qryString, sqlCon);
                da = new SqlDataAdapter(sqlCmd);
                ds = new DataSet();
                da.Fill(ds, "CustomersInfo");
                DataTable dtCustomers = ds.Tables["CustomersInfo"];
                var specificCustomers = from customer in dtCustomers.AsEnumerable()
                                        where customer.Field<string>("Country") == "UK"
                                        select new
                                        {
                                            custID = customer["CustomerID"],
                                            companyName = customer["CompanyName"],
                                            contactName = customer["ContactName"],
                                            address = customer["Address"],
                                            country = customer["Country"]
                                        };
                foreach(var customer in specificCustomers)
                {
                    Console.WriteLine("\n\nCustomerID: {0}", customer.custID);
                    Console.WriteLine("Name: {0}", customer.contactName);
                    Console.WriteLine("CompanyName: {0}", customer.companyName);
                    Console.WriteLine("Address: {0}", customer.address);
                    Console.WriteLine("Country: {0}", customer.country);
                }

                sqlCon.Close();
            }
        }
    }
}
