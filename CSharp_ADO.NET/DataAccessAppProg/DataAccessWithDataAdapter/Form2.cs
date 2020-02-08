using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataAccessWithDataAdapter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string conString, qryString;
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select * from Customers Where Country = '" + cmbCountries.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            ds.Clear();
            da.Fill(ds, "CustomersInfo");
            gvCustomersOrders.DataSource = ds;
            gvCustomersOrders.DataMember = "CustomersInfo";
        }

        private void btnCustomersAndOrders_Click(object sender, EventArgs e)
        {
            qryString = "Select c.CustomerID,c.CompanyName,c.ContactName,c.Address,c.Country,o.OrderID,o.OrderDate,o.ShippedDate from Customers c JOIN Orders o ON o.CustomerID = c.CustomerID";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            da.Fill(ds, "CustomersOrdersInfo");
            gvCustomersOrders.DataSource = ds;
            gvCustomersOrders.DataMember = "CustomersOrdersInfo";
        }
        private void btnProdCategories_Click(object sender, EventArgs e)
        {
            qryString = "Select p.ProductID,p.ProductName,p.UnitPrice,p.QuantityPerUnit,c.CategoryID,c.CategoryName from Products p JOIN Categories c ON p.CategoryID = c.CategoryID";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            ds.Clear();
            da.Fill(ds, "ProdCategories");
            gvCustomersOrders.DataSource = ds;
            gvCustomersOrders.DataMember = "ProdCategories";
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            qryString = "Select COUNT(OrderID) from Orders";

            // sqlCon = new SqlConnection(conString);
            // sqlCon.Open();
            // sqlCmd = new SqlCommand(qryString, sqlCon);
            // MessageBox.Show("Total orders placed: " + sqlCmd.ExecuteScalar().ToString(),"Total Orders");
            //sqlCon.Close();    

            //Alternative way of writing the code with 'using' statement
            using (sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                sqlCmd = new SqlCommand(qryString, sqlCon);
                MessageBox.Show("Total orders placed: " + sqlCmd.ExecuteScalar().ToString(), "Total Orders");
                sqlCon.Close();
            }
        }

        private void btnLINQDS_Click(object sender, EventArgs e)
        {
            qryString = "Select ProductID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products";
            using (sqlCon = new SqlConnection(conString))
            {
                sqlCmd = new SqlCommand(qryString, sqlCon);
                sqlCon.Open();
                da = new SqlDataAdapter(sqlCmd);
                ds.Clear();
                da.Fill(ds, "ProductsInfo");
                DataTable dt = ds.Tables["ProductsInfo"];
                var products = from product in dt.AsEnumerable()
                               where product.Field<decimal>("UnitPrice") >= 50
                               select new
                               {
                                   ProdID = product["ProductID"],
                                   ProdName = product["ProductName"],
                                   Price = product["UnitPrice"],
                                   Quantity = product["QuantityPerUnit"]
                               };
                foreach(var product in products)
                {
                    MessageBox.Show("ProductID = " + product.ProdID + " Name = " + product.ProdName + " Price = " + product.Price + " Quantity = " + product.Quantity, "Products with Price < 50.00");
                }

                sqlCon.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source=BLUESAPPHIRE\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            ds = new DataSet();
            qryString = "Select distinct Country from Customers";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            dr = sqlCmd.ExecuteReader();
            while(dr.Read())
            {
                cmbCountries.Items.Add(dr["Country"]);
            }
            dr.Close();
            sqlCon.Close();
        }

        
    }
}
