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
    public partial class FrmMessages : Form
    {
        public FrmMessages()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=MMAKTEPE-HP\MU;Initial Catalog=StarHotel;Integrated Security=True");

        private void showDatas()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Messages", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["MessageID"].ToString();
                add.SubItems.Add(read["Name"].ToString());
                add.SubItems.Add(read["Surname"].ToString());
                add.SubItems.Add(read["Message"].ToString());

                listView1.Items.Add(add);
            }
            connection.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Messages(Name, Surname, Message) values ('" + TxtName.Text + "','" + TxtSurname.Text + "','" + RchTxtMessage.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            showDatas();
        }

        private void FrmMessages_Load(object sender, EventArgs e)
        {
            showDatas();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            RchTxtMessage.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }
    }
}
