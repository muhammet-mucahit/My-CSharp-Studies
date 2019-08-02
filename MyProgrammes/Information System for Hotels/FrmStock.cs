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
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=MMAKTEPE-HP\MU;Initial Catalog=StarHotel;Integrated Security=True");  

        private void datas()
        {
            listView1.Items.Clear();

            connection.Open();
            SqlCommand command = new SqlCommand("select * from Stock", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["Food"].ToString();
                add.SubItems.Add(read["Drink"].ToString());
                add.SubItems.Add(read["Snack"].ToString());

                listView1.Items.Add(add);
            }

            connection.Close();
        }

        private void datas2()
        {
            listView2.Items.Clear();

            connection.Open();
            SqlCommand command2 = new SqlCommand("select * from Invoices", connection);
            SqlDataReader read2 = command2.ExecuteReader();

            while (read2.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read2["Electric"].ToString();
                add.SubItems.Add(read2["Water"].ToString());
                add.SubItems.Add(read2["Internet"].ToString());

                listView2.Items.Add(add);
            }

            connection.Close();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            datas();
            datas2();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Stock(Food, Drink, Snack) values ('" + TxtFood.Text + "','" + TxtDrink.Text + "','" + TxtSnack.Text + "')",connection);
            command.ExecuteNonQuery();
            connection.Close();
            datas();
        }

        private void BtnSave1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Invoices(Electric, Water, Internet) values ('" + TxtElectric1.Text + "','" + TxtWater1.Text + "','" + TxtInternet1.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            datas2();
        }
    }
}
