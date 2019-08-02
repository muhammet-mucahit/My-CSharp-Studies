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
    public partial class FrmUpdatePassword : Form
    {
        public FrmUpdatePassword()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=MMAKTEPE-HP\MU;Initial Catalog=StarHotel;Integrated Security=True");

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update AdminLogin set Username = '" + TxtUserName.Text + "',Password = '" + TxtPassword.Text + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("New password was updated!");
        }
    }
}
