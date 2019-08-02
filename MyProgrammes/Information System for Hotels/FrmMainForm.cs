using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_System_for_Hotels
{
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmAdminLogin fr1 = new FrmAdminLogin();
            fr1.Show();
            //this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmNewCustomer fr2 = new FrmNewCustomer();
            fr2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmRooms fr3 = new FrmRooms();
            fr3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmCustomers fr4 = new FrmCustomers();
            fr4.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Star Hotel Save Application / 2017 - Ostrava");
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmIncomeExpense fr = new FrmIncomeExpense();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmStock fr = new FrmStock();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmRadio fr = new FrmRadio();
            fr.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmNews fr = new FrmNews();
            fr.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmUpdatePassword fr = new FrmUpdatePassword();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMessages fr = new FrmMessages();
            fr.Show();
        }
    }
}
