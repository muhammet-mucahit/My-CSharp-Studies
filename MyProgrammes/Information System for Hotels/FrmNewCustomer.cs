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
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=MMAKTEPE-HP\MU;Initial Catalog=StarHotel;Integrated Security=True");

        private void FrmNewCustomer_Load(object sender, EventArgs e)
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
                BtnRoom101.Enabled = false;
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
                BtnRoom102.Enabled = false;
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
                BtnRoom103.Enabled = false;
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
                BtnRoom104.Enabled = false;
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
                BtnRoom105.Enabled = false;
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
                BtnRoom106.Enabled = false;
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
                BtnRoom107.Enabled = false;
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
                BtnRoom108.Enabled = false;
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
                BtnRoom109.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnRoom101_Click(object sender, EventArgs e)
        {
            TxtRoom.Text = "101";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room101 (Name, Surname) values ('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom102_Click(object sender, EventArgs e)
        {
            TxtRoom.Text = "102";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room102 (Name, Surname) values ('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom103_Click(object sender, EventArgs e)
        {
            TxtRoom.Text = "103";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room103 (Name, Surname) values ('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom104_Click(object sender, EventArgs e)
        {
            TxtRoom.Text = "104";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room104 (Name, Surname) values ('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom105_Click(object sender, EventArgs e)
        {
            TxtRoom.Text = "105";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room105 (Name, Surname) values ('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom106_Click(object sender, EventArgs e)
        {
            TxtRoom.Text = "106";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room106 (Name, Surname) values ('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom107_Click(object sender, EventArgs e)
        {
            TxtRoom.Text = "107";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room107 (Name, Surname) values ('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom108_Click(object sender, EventArgs e)
        {
            TxtRoom.Text = "108";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room108 (Name, Surname) values ('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnRoom109_Click(object sender, EventArgs e)
        {
            TxtRoom.Text = "109";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Room109 (Name, Surname) values ('" + TxtName.Text + "','" + TxtSurname.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void BtnFullRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Red Button show the full rooms");
        }

        private void BtnEmptyRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Green Button show the empty rooms");
        }

        private void DtpDeparture_ValueChanged(object sender, EventArgs e)
        {
            int Price;
            DateTime ArrivalTime = Convert.ToDateTime(DtpArrival.Text);
            DateTime DepartureTime = Convert.ToDateTime(DtpDeparture.Text);

            TimeSpan Result = DepartureTime - ArrivalTime;

            label11.Text = Result.TotalDays.ToString();

            Price = Convert.ToInt32(label11.Text);
            Price = Price * 50;

            TxtPrice.Text = Price.ToString();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            connection.Open(); 
            SqlCommand command = new SqlCommand("insert into AddCustomer (Name, Surname, Gender, Phone, Mail, IDNo, RoomNumber, Price, ArrivalDate, DepartureDate) values('" + TxtName.Text + "','" + TxtSurname.Text + "','" + comboBox1.Text + "','" + TxtPhone.Text + "','" + TxtMail.Text + "','" + TxtID.Text + "','" + TxtRoom.Text + "','" + TxtPrice.Text + "','" + DtpArrival.Value.ToString("yyyy-MM-dd") + "','" + DtpDeparture.Value.ToString("yyyy-MM-dd") + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Customer was saved!");
        }

        
    }
}

//Data Source=MMAKTEPE-HP\MU;Initial Catalog=StarHotel;Integrated Security=True