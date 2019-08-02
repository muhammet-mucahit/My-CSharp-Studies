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
    public partial class FrmRooms : Form
    {
        public FrmRooms()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=MMAKTEPE-HP\MU;Initial Catalog=StarHotel;Integrated Security=True");

        private void FrmRooms_Load(object sender, EventArgs e)
        {
            // Room 101
            connection.Open();
            SqlCommand command1 = new SqlCommand("select * from Room101", connection);
            SqlDataReader read1 = command1.ExecuteReader();

            while (read1.Read())
            {
                BtnRoom101.Text = read1["Name"].ToString() + " " + read1["Surname"].ToString();
            }
            connection.Close();

            if (BtnRoom101.Text != "101")
            {
                BtnRoom101.BackColor = Color.Red;
            }

            // Room 102
            connection.Open();
            SqlCommand command2 = new SqlCommand("select * from Room102", connection);
            SqlDataReader read2 = command2.ExecuteReader();

            while (read2.Read())
            {
                BtnRoom102.Text = read2["Name"].ToString() + " " + read2["Surname"].ToString();
            }
            connection.Close();

            if (BtnRoom102.Text != "102")
            {
                BtnRoom102.BackColor = Color.Red;
            }

            // Room 103
            connection.Open();
            SqlCommand command3 = new SqlCommand("select * from Room103", connection);
            SqlDataReader read3 = command3.ExecuteReader();

            while (read3.Read())
            {
                BtnRoom103.Text = read3["Name"].ToString() + " " + read3["Surname"].ToString();
            }
            connection.Close();

            if (BtnRoom103.Text != "103")
            {
                BtnRoom103.BackColor = Color.Red;
            }

            // Room 104
            connection.Open();
            SqlCommand command4 = new SqlCommand("select * from Room104", connection);
            SqlDataReader read4 = command4.ExecuteReader();

            while (read4.Read())
            {
                BtnRoom104.Text = read4["Name"].ToString() + " " + read4["Surname"].ToString();
            }
            connection.Close();

            if (BtnRoom104.Text != "104")
            {
                BtnRoom104.BackColor = Color.Red;
            }

            // Room 105
            connection.Open();
            SqlCommand command5 = new SqlCommand("select * from Room105", connection);
            SqlDataReader read5 = command5.ExecuteReader();

            while (read5.Read())
            {
                BtnRoom105.Text = read5["Name"].ToString() + " " + read5["Surname"].ToString();
            }
            connection.Close();

            if (BtnRoom105.Text != "105")
            {
                BtnRoom105.BackColor = Color.Red;
            }

            // Room 106
            connection.Open();
            SqlCommand command6 = new SqlCommand("select * from Room106", connection);
            SqlDataReader read6 = command6.ExecuteReader();

            while (read6.Read())
            {
                BtnRoom106.Text = read6["Name"].ToString() + " " + read6["Surname"].ToString();
            }
            connection.Close();

            if (BtnRoom106.Text != "106")
            {
                BtnRoom106.BackColor = Color.Red;
            }

            // Room 107
            connection.Open();
            SqlCommand command7 = new SqlCommand("select * from Room107", connection);
            SqlDataReader read7 = command7.ExecuteReader();

            while (read7.Read())
            {
                BtnRoom107.Text = read7["Name"].ToString() + " " + read7["Surname"].ToString();
            }
            connection.Close();

            if (BtnRoom107.Text != "107")
            {
                BtnRoom107.BackColor = Color.Red;
            }

            // Room 108
            connection.Open();
            SqlCommand command8 = new SqlCommand("select * from Room108", connection);
            SqlDataReader read8 = command8.ExecuteReader();

            while (read8.Read())
            {
                BtnRoom108.Text = read8["Name"].ToString() + " " + read8["Surname"].ToString();
            }
            connection.Close();

            if (BtnRoom108.Text != "108")
            {
                BtnRoom108.BackColor = Color.Red;
            }

            // Room 109
            connection.Open();
            SqlCommand command9 = new SqlCommand("select * from Room109", connection);
            SqlDataReader read9 = command9.ExecuteReader();

            while (read9.Read())
            {
                BtnRoom109.Text = read9["Name"].ToString() + " " + read9["Surname"].ToString();
            }
            connection.Close();

            if (BtnRoom109.Text != "109")
            {
                BtnRoom109.BackColor = Color.Red;
            }  
        }
    }
}
