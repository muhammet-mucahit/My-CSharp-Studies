using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Stack Logic

        private MyStack stack = new MyStack();

        private void button3_Click(object sender, EventArgs e)
        {
            stack.Push(Convert.ToInt32(txtStack.Text));
            txtStack.Text = String.Empty;
            VisualizeStack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int element = stack.Pop();
            MessageBox.Show(element.ToString());
            VisualizeStack();
        }

        private void VisualizeStack()
        {
            StackElements.Items.Clear();
            int[] elements = stack.Emelents;

            for (int i = elements.Length - 1; i >= 0; i--)
            {
                StackElements.Items.Add(elements[i]);
            }
        }

        #endregion 

        #region Queue Logic

        MyQueue queue = new MyQueue();

        private void button5_Click(object sender, EventArgs e)
        {
            queue.Add(Convert.ToInt32(txtQueue.Text));
            txtQueue.Text = String.Empty;
            VisualizeQueue();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int element = queue.Get();
            MessageBox.Show(element.ToString());
            VisualizeQueue();
        }

        private void VisualizeQueue()
        {
            QueueElements.Items.Clear();
            int[] elements = queue.Emelents;

            for (int i = 0; i < elements.Length; i++)
            {
                QueueElements.Items.Add(elements[i]);
            }
        }

        #endregion

        //private void button1_MouseDown(object sender, MouseEventArgs e)
        //{
            
        //}

        //private void button7_MouseUp(object sender, MouseEventArgs e)
        //{
            
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.CreateGraphics().DrawRectangle(Pens.Red, 10, 10, 100, 200);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.CreateGraphics().DrawEllipse(Pens.Blue, 150, 10, 100, 200);
        }
    }
}
