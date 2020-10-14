using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 mn = new Form5();
            mn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 mn = new Form8();
            mn.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mn = new Form1();
            mn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
