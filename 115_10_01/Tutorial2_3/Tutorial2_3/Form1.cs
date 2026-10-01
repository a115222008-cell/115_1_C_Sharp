using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 義大利按鈕_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buongiorno";
        }

        private void 西班牙按鈕_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buenos dias";
        }

        private void translateLabel_Click(object sender, EventArgs e)
        {

        }

        private void 德國按鈕_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "hello";
        }
    }
}
