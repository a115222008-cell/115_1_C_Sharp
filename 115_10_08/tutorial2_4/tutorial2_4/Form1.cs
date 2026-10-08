using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 國家label_Click(object sender, EventArgs e)
        {

        }

        private void 芬蘭pictureBox_Click(object sender, EventArgs e)
        {
            國家label.Text = "芬蘭";
        }

        private void 法國pictureBox_Click(object sender, EventArgs e)
        {
            國家label.Text = "法國";
        }

        private void 德國pictureBox_Click(object sender, EventArgs e)
        {
            國家label.Text = "德國";
        }
    }
}
