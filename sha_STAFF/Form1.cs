using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sha_STAFF
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

        private void button2_Click(object sender, EventArgs e)
        {
            string username = "ahmed"; // from db
            int pass = 123; // from db
            string name = textBox1.Text;
            int password =Convert.ToInt32( textBox2.Text);
            if (username==name&&pass==password)
            {
                Form2 f = new Form2();
                this.Hide();
                f.ShowDialog();

            }
            else
            {
                label3.Visible = true;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }
    }
}
