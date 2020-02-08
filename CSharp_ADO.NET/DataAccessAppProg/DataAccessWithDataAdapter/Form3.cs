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
    public partial class Form3 : Form
    {
        string conString, qryString;
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            conString = "data source=BLUESAPPHIRE\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";

            using (sqlCon = new SqlConnection(conString))
            {
                sqlCmd = new SqlCommand();
                sqlCmd.CommandText = "GetCustomersByCountry";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Connection = sqlCon;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@country";
                param.DbType = DbType.String;
                param.Value = cmbCountries.Text;

                sqlCmd.Parameters.Add(param);
                da = new SqlDataAdapter(sqlCmd);
                ds.Clear();
                da.Fill(ds, "CustomersByCountry");

                gvCustomers.DataSource = ds;
                gvCustomers.DataMember = "CustomersByCountry";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conString = "data source=BLUESAPPHIRE\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            ds = new DataSet();

            using (sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                qryString = "Select distinct Country from Customers";
                sqlCmd = new SqlCommand(qryString, sqlCon);

                dr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(dr.Read())
                {
                    cmbCountries.Items.Add(dr["Country"]);
                }
                dr.Close();
            }
        }
    }
}
