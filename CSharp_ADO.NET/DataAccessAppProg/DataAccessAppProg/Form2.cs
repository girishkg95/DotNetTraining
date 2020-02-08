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

namespace DataAccessAppProg
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

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlCon.Open();
            qryString = "Select ContactName from Customers Where Country = '" + cmbCountries.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            lsbContacts.Items.Clear();
            while(dr.Read())
            {
                lsbContacts.Items.Add(dr["ContactName"]);
            }
            dr.Close();
            sqlCon.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source=BLUESAPPHIRE\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            qryString = "Select distinct Country from Customers";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while(dr.Read())
            {
                cmbCountries.Items.Add(dr["Country"]);
            }
            dr.Close();
            sqlCon.Close();

            cmbCountries.Text = "All Countries";

        }
    }
}
