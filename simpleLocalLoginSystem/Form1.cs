using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleLocalLoginSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text =="123456")
            {
                homePage hp = new homePage();
                hp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password","Alert!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
