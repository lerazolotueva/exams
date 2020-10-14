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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox1.PasswordChar = '*';
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 mn = new Form5();
            mn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 mn = new Form3();
            mn.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
