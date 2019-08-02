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
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=MMAKTEPE-HP\MU;Initial Catalog=StarHotel;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string sql = "select * from AdminLogin where UserName = @UserName and Password = @Password";
                SqlParameter prm1 = new SqlParameter("@UserName", TxtUserName.Text.Trim());
                SqlParameter prm2 = new SqlParameter("@Password", TxtPassword.Text.Trim());
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add(prm1);
                command.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FrmMainForm fr = new FrmMainForm();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Login");
                throw;
            }
        }
    }
}
