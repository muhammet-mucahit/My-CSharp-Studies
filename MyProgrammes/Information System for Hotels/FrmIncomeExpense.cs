using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Information_System_for_Hotels
{
    public partial class FrmIncomeExpense : Form
    {
        public FrmIncomeExpense()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=MMAKTEPE-HP\MU;Initial Catalog=StarHotel;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            int staff = Convert.ToInt16(textBox1.Text);
            LblStaffSalary.Text = (staff * 1500).ToString();

            int result = Convert.ToInt32(LblCaseTotal.Text) - (Convert.ToInt32(LblStaffSalary.Text) + Convert.ToInt32(LblProductPrice1.Text) + Convert.ToInt32(LblProductPrice2.Text) + Convert.ToInt32(LblProductPrice3.Text) + Convert.ToInt32(LblInvoices1.Text) + Convert.ToInt32(LblInvoices2.Text) + Convert.ToInt32(LblInvoices3.Text));
            LblResult.Text = result.ToString();
        }

        private void FrmIncomeExpense_Load(object sender, EventArgs e)
        {
            // Total amount in Case
            connection.Open();
            SqlCommand command = new SqlCommand("select sum(Price) as Total from AddCustomer", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                LblCaseTotal.Text = read["Total"].ToString();
            }

            connection.Close();

            // Expense of Food
            connection.Open();
            SqlCommand command2 = new SqlCommand("select sum(Food) as Total1 from Stock", connection);
            SqlDataReader read2 = command2.ExecuteReader();

            while (read2.Read())
            {
                LblProductPrice1.Text = read2["Total1"].ToString();
            }

            connection.Close();

            // Expense of Drink
            connection.Open();
            SqlCommand command3 = new SqlCommand("select sum(Drink) as Total2 from Stock", connection);
            SqlDataReader read3 = command3.ExecuteReader();

            while (read3.Read())
            {
                LblProductPrice2.Text = read3["Total2"].ToString();
            }

            connection.Close();

            // Expense of Snack
            connection.Open();
            SqlCommand command4 = new SqlCommand("select sum(Snack) as Total3 from Stock", connection);
            SqlDataReader read4 = command4.ExecuteReader();

            while (read4.Read())
            {
                LblProductPrice3.Text = read4["Total3"].ToString();
            }

            connection.Close();

            // Invoice of Electric
            connection.Open();
            SqlCommand command5 = new SqlCommand("select sum(Electric) as Total4 from Invoices", connection);
            SqlDataReader read5 = command5.ExecuteReader();

            while (read5.Read())
            {
                LblInvoices1.Text = read5["Total4"].ToString();
            }

            connection.Close();

            // Invoice of Water
            connection.Open();
            SqlCommand command6 = new SqlCommand("select sum(Water) as Total5 from Invoices", connection);
            SqlDataReader read6 = command6.ExecuteReader();

            while (read6.Read())
            {
                LblInvoices2.Text = read6["Total5"].ToString();
            }

            connection.Close();

            // Invoice of Internet
            connection.Open();
            SqlCommand command7 = new SqlCommand("select sum(Internet) as Total6 from Invoices", connection);
            SqlDataReader read7 = command7.ExecuteReader();

            while (read7.Read())
            {
                LblInvoices3.Text = read7["Total6"].ToString();
            }

            connection.Close();
        }
    }
}
