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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=MMAKTEPE-HP\MU;Initial Catalog=StarHotel;Integrated Security=True");

        private void showDatas()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from AddCustomer", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["CustomerID"].ToString();
                add.SubItems.Add(read["Name"].ToString());
                add.SubItems.Add(read["Surname"].ToString());
                add.SubItems.Add(read["Gender"].ToString());
                add.SubItems.Add(read["Phone"].ToString());
                add.SubItems.Add(read["Mail"].ToString());
                add.SubItems.Add(read["IDNo"].ToString());
                add.SubItems.Add(read["RoomNumber"].ToString());
                add.SubItems.Add(read["Price"].ToString());
                add.SubItems.Add(read["ArrivalDate"].ToString());
                add.SubItems.Add(read["DepartureDate"].ToString());

                listView1.Items.Add(add);
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showDatas();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TxtPhone.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtID.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtRoom.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtPrice.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpArrival.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpDeparture.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtRoom.Text == "101")
            {
                connection.Open();
                //SqlCommand command = new SqlCommand("delete from AddCustomer where CustomerID = (" + id + ")", connection);
                SqlCommand command = new SqlCommand("delete from Room101", connection);
                command.ExecuteNonQuery();
                connection.Close();
                showDatas();
            }
            
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtSurname.Clear();
            comboBox1.Text = "";
            TxtPhone.Clear();
            TxtMail.Clear();
            TxtID.Clear();
            TxtRoom.Clear();
            TxtPrice.Clear();
            DtpArrival.Text = "";
            DtpDeparture.Text = "";
            //TxtMail.Text = "";

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update AddCustomer set Name = '" + TxtName.Text + "',Surname = '" + TxtSurname.Text + "',Gender = '" + comboBox1.Text + "',Phone = '" + TxtPhone.Text + "',Mail = '" + TxtMail.Text + "',IDNo = '" + TxtID.Text + "',RoomNumber = '" + TxtRoom.Text + "',Price = '" + TxtPrice.Text + "',ArrivalDate = '" + DtpArrival.Value.ToString("yyyy-MM-dd") + "',DepartureDate = '" + DtpDeparture.Value.ToString("yyyy-MM-dd") + "'where CustomerID = " + id + "", connection);
            command.ExecuteNonQuery();
            connection.Close();
            showDatas();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from AddCustomer where Name like '%" + textBox1.Text + "%'", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["CustomerID"].ToString();
                add.SubItems.Add(read["Name"].ToString());
                add.SubItems.Add(read["Surname"].ToString());
                add.SubItems.Add(read["Gender"].ToString());
                add.SubItems.Add(read["Phone"].ToString());
                add.SubItems.Add(read["Mail"].ToString());
                add.SubItems.Add(read["IDNo"].ToString());
                add.SubItems.Add(read["RoomNumber"].ToString());
                add.SubItems.Add(read["Price"].ToString());
                add.SubItems.Add(read["ArrivalDate"].ToString());
                add.SubItems.Add(read["DepartureDate"].ToString());

                listView1.Items.Add(add);
            }
            connection.Close();
        }
    }
}
