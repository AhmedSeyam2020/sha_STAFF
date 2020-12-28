using sha_STAFF.Properties;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Black2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Black1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.ShowDialog();
        }
    }
}
